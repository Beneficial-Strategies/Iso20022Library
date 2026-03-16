// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections;
using System.Collections.Concurrent;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Framework;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Reflection-based XML serializer for ISO 20022 message records.
/// </summary>
/// <remarks>
/// <para>
/// All ISO 20022 elements share the namespace declared on the root message type via its
/// <c>DocumentNamespace</c> constant — child components like <c>GroupHeader81</c> carry no
/// namespace of their own and inherit it from the message root.  This makes
/// <see cref="System.Xml.Serialization.XmlSerializer"/> impractical (it requires a
/// static, compile-time namespace per type).  This serializer resolves the namespace once
/// from the root message constant and threads it through the entire object graph.
/// </para>
/// <para>
/// <b>Choice types</b> come in two forms:
/// <list type="bullet">
///   <item><b>Simple</b> — single <c>[IsoXmlTag]</c>-decorated property; the tag IS the
///     discriminating element (e.g. <c>&lt;Cd&gt;CUST&lt;/Cd&gt;</c>).</item>
///   <item><b>Complex</b> — multiple properties; the class carries a class-level
///     <c>[IsoXmlTag("Agt")]</c> that becomes the discriminating wrapper element
///     (e.g. <c>&lt;Agt&gt;&lt;FinInstnId&gt;…&lt;/FinInstnId&gt;&lt;/Agt&gt;</c>).
///     Add this attribute to any complex choice variant class that lacks it.</item>
/// </list>
/// </para>
/// <para>
/// Reflection metadata is cached per type on first use; subsequent calls are fast.
/// </para>
/// </remarks>
public static class Iso20022XmlSerializer
{
    // ── Public API ─────────────────────────────────────────────────────────────

    /// <summary>Serializes an ISO 20022 message record to an <see cref="XDocument"/>.</summary>
    public static XDocument Serialize<TMessage>(TMessage message)
        where TMessage : IOuterRecord
    {
        var (ns, xmlTag, docElem) = GetMessageConstants(typeof(TMessage));
        var root = new XElement(
            ns + docElem,
            new XAttribute("xmlns", ns.NamespaceName),
            SerializeObject(message, ns, xmlTag)
        );
        return new XDocument(new XDeclaration("1.0", "UTF-8", null), root);
    }

    /// <summary>Serializes an ISO 20022 message record to an XML string.</summary>
    public static string SerializeToString<TMessage>(TMessage message)
        where TMessage : IOuterRecord => Serialize(message).ToString(SaveOptions.None);

    /// <summary>Deserializes an <see cref="XDocument"/> to an ISO 20022 message record.</summary>
    public static TMessage Deserialize<TMessage>(XDocument document)
        where TMessage : IOuterRecord
    {
        var (ns, xmlTag, docElem) = GetMessageConstants(typeof(TMessage));
        var docRoot =
            document.Root ?? throw new InvalidOperationException("Document has no root element.");
        var messageRoot =
            docRoot.Element(ns + xmlTag)
            ?? throw new InvalidOperationException(
                $"Expected <{xmlTag}> under <{docElem}> in namespace '{ns}'."
            );
        return (TMessage)DeserializeObject(typeof(TMessage), messageRoot, ns);
    }

    /// <summary>Deserializes an XML string to an ISO 20022 message record.</summary>
    public static TMessage Deserialize<TMessage>(string xml)
        where TMessage : IOuterRecord => Deserialize<TMessage>(XDocument.Parse(xml));

    // ── Message constants ──────────────────────────────────────────────────────

    private static (XNamespace Ns, string XmlTag, string DocElem) GetMessageConstants(Type t)
    {
        var ns = XNamespace.Get(GetConstant<string>(t, "DocumentNamespace"));
        var xmlTag = GetConstant<string>(t, "XmlTag");
        var docElem = GetConstant<string>(t, "DocumentElementName");
        return (ns, xmlTag, docElem);
    }

    private static T GetConstant<T>(Type type, string name) =>
        (T)(
            type.GetField(name, BindingFlags.Public | BindingFlags.Static)?.GetValue(null)
            ?? throw new InvalidOperationException(
                $"Missing public static field '{name}' on {type.Name}."
            )
        );

    // ── Reflection metadata cache ──────────────────────────────────────────────

    private sealed record PropMeta(
        PropertyInfo Property,
        string XmlTag,
        bool IsCollection,
        Type CoreType, // element type for collections; declared type (nullable-unwrapped) otherwise
        bool CoreIsLeaf
    ); // whether CoreType is a primitive leaf

    private static readonly ConcurrentDictionary<Type, PropMeta[]> PropCache = new();

    private static PropMeta[] GetProps(Type type) => PropCache.GetOrAdd(type, BuildProps);

    private static PropMeta[] BuildProps(Type type)
    {
        var result = new List<PropMeta>();
        foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            var tagAttr = prop.GetCustomAttribute<IsoXmlTagAttribute>();
            if (tagAttr is null)
                continue;

            var declared = UnwrapNullable(prop.PropertyType);
            bool isCol = TryGetCollectionElement(declared, out var elemType);
            var core = elemType ?? declared;
            result.Add(new PropMeta(prop, tagAttr.XmlTag, isCol, core, IsLeafType(core)));
        }
        return [.. result];
    }

    // Cache: choice abstract type → [(discriminating xml tag, concrete variant type)]
    private static readonly ConcurrentDictionary<Type, (string Tag, Type Variant)[]> ChoiceCache =
        new();

    private static (string Tag, Type Variant)[] GetChoiceVariants(Type abstractType) =>
        ChoiceCache.GetOrAdd(abstractType, BuildChoiceVariants);

    private static (string Tag, Type Variant)[] BuildChoiceVariants(Type abstractType)
    {
        var result = new List<(string, Type)>();
        foreach (var attr in abstractType.GetCustomAttributes<JsonDerivedTypeAttribute>())
        {
            var tag = GetVariantTag(attr.DerivedType);
            if (tag is not null)
                result.Add((tag, attr.DerivedType));
        }
        return [.. result];
    }

    /// <summary>
    /// Gets the discriminating XML element name for a choice variant type.
    /// Complex variants (multiple properties) must have a class-level [IsoXmlTag].
    /// Simple variants (single property) use that property's tag.
    /// </summary>
    private static string? GetVariantTag(Type variantType)
    {
        var classTag = variantType.GetCustomAttribute<IsoXmlTagAttribute>();
        if (classTag is not null)
            return classTag.XmlTag;

        var props = GetProps(variantType);
        return props.Length == 1 ? props[0].XmlTag : null;
    }

    // ── Serialization ──────────────────────────────────────────────────────────

    private static XElement SerializeObject(object obj, XNamespace ns, string tag)
    {
        var el = new XElement(ns + tag);
        foreach (var meta in GetProps(obj.GetType()))
        {
            var value = meta.Property.GetValue(obj);
            if (value is null)
                continue;

            if (meta.IsCollection)
            {
                foreach (var item in (IEnumerable)value)
                    el.Add(SerializeValue(item, ns, meta.XmlTag, meta.CoreType, meta.CoreIsLeaf));
            }
            else
            {
                el.Add(
                    SerializeValue(
                        value,
                        ns,
                        meta.XmlTag,
                        UnwrapNullable(meta.Property.PropertyType),
                        meta.CoreIsLeaf
                    )
                );
            }
        }
        return el;
    }

    private static XElement SerializeValue(
        object value,
        XNamespace ns,
        string tag,
        Type declaredType,
        bool isLeaf
    )
    {
        if (isLeaf)
            return new XElement(ns + tag, FormatLeaf(value));

        var runtimeType = value.GetType();
        if (runtimeType.IsEnum)
            return new XElement(ns + tag, GetEnumMemberValue(value));

        // Abstract declared type = choice: find the variant's discriminating element
        if (declaredType.IsAbstract)
        {
            var variants = GetChoiceVariants(declaredType);
            var match = variants.FirstOrDefault(v => v.Variant == runtimeType);
            if (match == default)
                throw new NotSupportedException(
                    $"Choice variant '{runtimeType.Name}' of '{declaredType.Name}' has no XML tag. "
                        + $"Add [IsoXmlTag(\"...\")]  at the class level."
                );

            var hasClassTag = runtimeType.GetCustomAttribute<IsoXmlTagAttribute>() is not null;
            var wrapper = new XElement(ns + tag);

            if (hasClassTag)
            {
                // Complex variant: normally <tag><VariantTag>...properties...</VariantTag></tag>
                // Exception: if the variant itself is an amount type (e.g. InstructedAmount with
                // Currency+Amount), serialize as <tag><VariantTag Ccy="EUR">47250.00</VariantTag></tag>
                if (IsAmountType(runtimeType))
                    wrapper.Add(SerializeAmount(value, ns, match.Tag));
                else
                    wrapper.Add(SerializeObject(value, ns, match.Tag));
            }
            else
            {
                // Simple variant: <tag><discriminatorTag>leaf-or-object</discriminatorTag></tag>
                var variantProps = GetProps(runtimeType);
                var inner = variantProps[0].Property.GetValue(value);
                if (inner is not null)
                    wrapper.Add(
                        SerializeValue(
                            inner,
                            ns,
                            match.Tag,
                            UnwrapNullable(variantProps[0].Property.PropertyType),
                            variantProps[0].CoreIsLeaf
                        )
                    );
            }
            return wrapper;
        }

        // Currency-and-amount types: <Tag Ccy="EUR">47250.00</Tag>
        if (IsAmountType(runtimeType))
            return SerializeAmount(value, ns, tag);

        // Concrete component: recurse
        return SerializeObject(value, ns, tag);
    }

    // ── Deserialization ────────────────────────────────────────────────────────

    private static object DeserializeObject(Type type, XElement el, XNamespace ns)
    {
        // Activator.CreateInstance runs the parameterless ctor, which sets collection defaults (= []).
        var instance =
            Activator.CreateInstance(type)
            ?? throw new InvalidOperationException($"Cannot create instance of {type.Name}.");

        foreach (var meta in GetProps(type))
        {
            var propDeclared = UnwrapNullable(meta.Property.PropertyType);

            if (meta.IsCollection)
            {
                var children = el.Elements(ns + meta.XmlTag).ToList();
                if (children.Count == 0)
                    continue;
                var items = children
                    .Select(child => DeserializeValue(meta.CoreType, child, ns, meta.CoreIsLeaf))
                    .ToList();
                meta.Property.SetValue(
                    instance,
                    CreateList(meta.Property.PropertyType, meta.CoreType, items)
                );
            }
            else if (propDeclared.IsAbstract)
            {
                var child = el.Element(ns + meta.XmlTag);
                if (child is null)
                    continue;
                meta.Property.SetValue(instance, DeserializeChoice(propDeclared, child, ns));
            }
            else
            {
                var child = el.Element(ns + meta.XmlTag);
                if (child is null)
                    continue;
                meta.Property.SetValue(
                    instance,
                    DeserializeValue(propDeclared, child, ns, meta.CoreIsLeaf)
                );
            }
        }
        return instance;
    }

    private static object DeserializeValue(Type type, XElement el, XNamespace ns, bool isLeaf)
    {
        var core = UnwrapNullable(type);
        if (isLeaf || IsLeafType(core))
            return ParseLeaf(core, el.Value);
        if (core.IsEnum)
            return ParseEnum(core, el.Value);
        if (core.IsAbstract)
            return DeserializeChoice(core, el, ns);
        if (IsAmountType(core))
            return DeserializeAmount(core, el);
        return DeserializeObject(core, el, ns);
    }

    private static object DeserializeChoice(Type abstractType, XElement parentEl, XNamespace ns)
    {
        var variants = GetChoiceVariants(abstractType);
        if (variants.Length == 0)
            throw new NotSupportedException(
                $"No XML tag mappings found for choice type '{abstractType.Name}'. "
                    + "Ensure [JsonDerivedType] is present on the abstract base and "
                    + "[IsoXmlTag] is on each complex variant class."
            );

        foreach (var (tag, variantType) in variants)
        {
            var hasClassTag = variantType.GetCustomAttribute<IsoXmlTagAttribute>() is not null;
            if (hasClassTag)
            {
                // Complex variant: look for <tag> wrapper
                var wrapperEl = parentEl.Element(ns + tag);
                if (wrapperEl is null)
                    continue;
                // Amount-like variants (e.g. InstructedAmount) use Ccy-attribute format
                if (IsAmountType(variantType))
                    return DeserializeAmount(variantType, wrapperEl);
                return DeserializeObject(variantType, wrapperEl, ns);
            }
            else
            {
                // Simple variant: look for discriminating inner element
                var innerEl = parentEl.Element(ns + tag);
                if (innerEl is null)
                    continue;
                var variantProps = GetProps(variantType);
                var instance =
                    Activator.CreateInstance(variantType)
                    ?? throw new InvalidOperationException($"Cannot create {variantType.Name}.");
                var v = DeserializeValue(
                    variantProps[0].CoreType,
                    innerEl,
                    ns,
                    variantProps[0].CoreIsLeaf
                );
                variantProps[0].Property.SetValue(instance, v);
                return instance;
            }
        }

        var present = string.Join(", ", parentEl.Elements().Select(e => $"<{e.Name.LocalName}>"));
        throw new InvalidOperationException(
            $"Cannot match [{present}] to any variant of '{abstractType.Name}'."
        );
    }

    // ── Collection construction ────────────────────────────────────────────────

    private static object CreateList(Type listType, Type elementType, List<object> rawItems)
    {
        // Cast List<object> → IEnumerable<TElement> at runtime, then invoke IEnumerable<T> ctor.
        var castMethod = typeof(Enumerable)
            .GetMethod(nameof(Enumerable.Cast), BindingFlags.Public | BindingFlags.Static)!
            .MakeGenericMethod(elementType);
        var typed = castMethod.Invoke(null, [rawItems])!;
        return Activator.CreateInstance(listType, [typed])!;
    }

    // ── Leaf formatting ────────────────────────────────────────────────────────

    private static string FormatLeaf(object value) =>
        value switch
        {
            string s => s,
            DateTime dt => dt.ToString("yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture),
            DateOnly d => d.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
            TimeOnly t => t.ToString("HH:mm:ss", CultureInfo.InvariantCulture),
            ulong n => n.ToString(CultureInfo.InvariantCulture),
            decimal d => d.ToString(CultureInfo.InvariantCulture),
            ushort s => s.ToString(CultureInfo.InvariantCulture),
            byte b => b.ToString(CultureInfo.InvariantCulture),
            byte[] bytes => Convert.ToBase64String(bytes),
            _ when value.GetType().IsEnum => GetEnumMemberValue(value),
            _ => value.ToString() ?? string.Empty,
        };

    private static object ParseLeaf(Type type, string text)
    {
        if (type == typeof(string))
            return text;
        if (type == typeof(DateTime))
            return DateTime.Parse(text, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
        if (type == typeof(DateOnly))
            return DateOnly.Parse(text, CultureInfo.InvariantCulture);
        if (type == typeof(TimeOnly))
            return TimeOnly.Parse(text, CultureInfo.InvariantCulture);
        if (type == typeof(ulong))
            return ulong.Parse(text, CultureInfo.InvariantCulture);
        if (type == typeof(decimal))
            return decimal.Parse(text, CultureInfo.InvariantCulture);
        if (type == typeof(ushort))
            return ushort.Parse(text, CultureInfo.InvariantCulture);
        if (type == typeof(byte))
            return byte.Parse(text, CultureInfo.InvariantCulture);
        if (type == typeof(byte[]))
            return Convert.FromBase64String(text);
        if (type.IsEnum)
            return ParseEnum(type, text);
        return text;
    }

    private static string GetEnumMemberValue(object enumValue)
    {
        var name = enumValue.ToString()!;
        var field = enumValue.GetType().GetField(name);
        return field?.GetCustomAttribute<EnumMemberAttribute>()?.Value ?? name;
    }

    private static object ParseEnum(Type enumType, string text)
    {
        foreach (var field in enumType.GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            var memberValue = field.GetCustomAttribute<EnumMemberAttribute>()?.Value ?? field.Name;
            if (memberValue == text)
                return field.GetValue(null)!;
        }
        // Fallback: try by C# name (e.g. for external codeset strings stored as-is)
        if (Enum.TryParse(enumType, text, out var result))
            return result!;
        throw new InvalidOperationException($"Unknown value '{text}' for enum {enumType.Name}.");
    }

    // ── Currency-and-amount helpers ────────────────────────────────────────────

    /// <summary>
    /// ISO 20022 currency-and-amount types (all in the Amounts namespace) are serialized as
    /// <c>&lt;Tag Ccy="EUR"&gt;47250.00&lt;/Tag&gt;</c> — an XML attribute for currency and
    /// text content for the decimal amount — to match the ISO XSD simpleContent pattern.
    /// </summary>
    private static bool IsAmountType(Type t) =>
        t.Namespace == "BeneficialStrategies.Iso20022.Amounts" || HasCurrencyAndAmountProperties(t);

    /// <summary>
    /// Returns true for types that carry exactly the ISO currency-and-amount property pair:
    /// a string property tagged "Currency" and a decimal property tagged "Amount".
    /// This catches both the canonical <c>Amounts</c>-namespace types and choice variants
    /// such as <c>AmountType4Choice.InstructedAmount</c> that replicate the same structure.
    /// </summary>
    private static bool HasCurrencyAndAmountProperties(Type t)
    {
        var props = GetProps(t);
        return props.Any(p => p.XmlTag == "Currency" && p.CoreType == typeof(string))
            && props.Any(p => p.XmlTag == "Amount" && p.CoreType == typeof(decimal));
    }

    private static XElement SerializeAmount(object obj, XNamespace ns, string tag)
    {
        var props = GetProps(obj.GetType());
        var currency =
            props.First(p => p.XmlTag == "Currency").Property.GetValue(obj) as string ?? "";
        var amount = (decimal)props.First(p => p.XmlTag == "Amount").Property.GetValue(obj)!;
        return new XElement(
            ns + tag,
            new XAttribute("Ccy", currency),
            amount.ToString(CultureInfo.InvariantCulture)
        );
    }

    private static object DeserializeAmount(Type type, XElement el)
    {
        var instance =
            Activator.CreateInstance(type)
            ?? throw new InvalidOperationException($"Cannot create instance of {type.Name}.");
        var props = GetProps(type);
        var currencyProp = props.First(p => p.XmlTag == "Currency").Property;
        var amountProp = props.First(p => p.XmlTag == "Amount").Property;
        currencyProp.SetValue(instance, el.Attribute("Ccy")?.Value ?? "");
        amountProp.SetValue(instance, decimal.Parse(el.Value, CultureInfo.InvariantCulture));
        return instance;
    }

    // ── Type helpers ───────────────────────────────────────────────────────────

    private static bool IsLeafType(Type t) =>
        t == typeof(string)
        || t == typeof(DateTime)
        || t == typeof(DateOnly)
        || t == typeof(TimeOnly)
        || t == typeof(ulong)
        || t == typeof(decimal)
        || t == typeof(ushort)
        || t == typeof(byte)
        || t == typeof(byte[])
        || t.IsEnum;

    private static bool TryGetCollectionElement(Type t, out Type? elementType)
    {
        // Check direct generic definition
        if (t.IsGenericType)
        {
            var gd = t.GetGenericTypeDefinition();
            if (
                gd == typeof(ImmutableValueList<>)
                || gd == typeof(ValueList<>)
                || gd == typeof(SimpleValueList<>)
            )
            {
                elementType = t.GetGenericArguments()[0];
                return true;
            }
        }
        // Walk the inheritance chain (ValueList<T> → ImmutableValueList<T>)
        for (var b = t.BaseType; b is not null && b != typeof(object); b = b.BaseType)
        {
            if (b.IsGenericType && b.GetGenericTypeDefinition() == typeof(ImmutableValueList<>))
            {
                elementType = b.GetGenericArguments()[0];
                return true;
            }
        }
        elementType = null;
        return false;
    }

    private static Type UnwrapNullable(Type t) => Nullable.GetUnderlyingType(t) ?? t;
}
