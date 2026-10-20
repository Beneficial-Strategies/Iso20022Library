// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Serialization;

// The reader that reports every problem (issue #19). It walks the same metadata as Deserialize,
// but never throws for a problem in the document: each one is added to the issue list and the
// walk goes on with the next member. If the list is empty at the end the record is returned,
// otherwise only the list is, because a record built around a problem is not valid.
public static partial class Iso20022XmlSerializer
{
    // ── Public API ─────────────────────────────────────────────────────────────

    /// <summary>Reads an XML string into a message, reporting every problem found.</summary>
    public static DeserializationResult<TMessage> TryRead<TMessage>(string? xml, IIsoDataFactory? factory = null)
        where TMessage : class, IOuterRecord
    {
        if (xml is null)
            return DeserializationResult<TMessage>.Failure(
                [new DeserializationIssue("", IssueCode.MalformedXml, null, "There is no XML text.")]
            );
        XDocument document;
        try
        {
            document = XDocument.Parse(xml, LoadOptions.SetLineInfo);
        }
        catch (XmlException ex)
        {
            return DeserializationResult<TMessage>.Failure(
                [new DeserializationIssue("", IssueCode.MalformedXml, null, ex.Message, ex.LineNumber, ex.LinePosition)]
            );
        }
        return TryRead<TMessage>(document, factory);
    }

    /// <summary>Reads a document into a message, reporting every problem found.</summary>
    public static DeserializationResult<TMessage> TryRead<TMessage>(XDocument? document, IIsoDataFactory? factory = null)
        where TMessage : class, IOuterRecord
    {
        var sink = new ReadSink(factory);
        var (ns, xmlTag, docElem) = GetMessageConstants(typeof(TMessage));
        var root = document?.Root;
        if (root is null)
            return DeserializationResult<TMessage>.Failure(
                [new DeserializationIssue("", IssueCode.WrongRoot, null, "The document has no root element.")]
            );
        if (root.Name != ns + docElem)
            sink.Add(root, root.Name.LocalName, IssueCode.WrongRoot, root.Name.ToString(), $"Expected <{docElem}> in namespace '{ns}'.");
        var messageRoot = root.Element(ns + xmlTag);
        if (messageRoot is null)
        {
            sink.Add(root, $"{docElem}/{xmlTag}", IssueCode.WrongRoot, null, $"Expected <{xmlTag}> under <{docElem}> in namespace '{ns}'.");
            return DeserializationResult<TMessage>.Failure(sink.Issues);
        }
        var message = ReadObject(typeof(TMessage), messageRoot, ns, $"{docElem}/{xmlTag}", sink);
        return sink.Issues.Count == 0
            ? DeserializationResult<TMessage>.Success((TMessage)message)
            : DeserializationResult<TMessage>.Failure(sink.Issues);
    }

    /// <summary>
    /// Reads any part of a document: a component, a choice or a message, rooted at <paramref name="element"/>.
    /// The element's own name is not checked, since the same type appears under many tags.
    /// </summary>
    public static DeserializationResult<T> Read<T>(XElement element, ReadContext? context = null, IIsoDataFactory? factory = null)
        where T : class
    {
        var ns = context?.Namespace ?? element.Name.Namespace;
        var path = (context?.PathPrefix ?? "") + element.Name.LocalName;
        var sink = new ReadSink(factory);
        var value = ReadValue(typeof(T), element, ns, path, sink, isLeaf: false);
        return sink.Issues.Count == 0 && value is T typed
            ? DeserializationResult<T>.Success(typed)
            : DeserializationResult<T>.Failure(sink.Issues);
    }

    // ── The walk ───────────────────────────────────────────────────────────────

    private sealed class ReadSink(IIsoDataFactory? factory)
    {
        /// <summary>Makes the objects for interfaces; records are created directly.</summary>
        public IIsoDataFactory Factory { get; } = factory ?? NoDataFactory.Instance;

        public List<DeserializationIssue> Issues { get; } = [];

        public void Add(XObject? at, string path, IssueCode code, string? value, string reason)
        {
            int? line = null,
                position = null;
            if (at is IXmlLineInfo info && info.HasLineInfo())
                (line, position) = (info.LineNumber, info.LinePosition);
            Issues.Add(new DeserializationIssue(path, code, value, reason, line, position));
        }
    }

    // The instance is returned even when problems were found inside it; the caller discards it
    // if the sink is not empty at the end.
    private static object ReadObject(Type type, XElement el, XNamespace ns, string path, ReadSink sink)
    {
        var instance = Create(type, sink);
        var props = GetProps(type);

        foreach (var child in el.Elements())
            if (child.Name.Namespace != ns || !props.Any(p => p.XmlTag == child.Name.LocalName))
                sink.Add(child, $"{path}/{child.Name.LocalName}", IssueCode.UnexpectedElement, null,
                    $"<{type.Name}> has no element <{child.Name.LocalName}>.");

        foreach (var meta in props)
        {
            var propPath = $"{path}/{meta.XmlTag}";
            var propType = UnwrapNullable(meta.Property.PropertyType);

            if (meta.IsCollection)
            {
                var children = el.Elements(ns + meta.XmlTag).ToList();
                if (children.Count == 0)
                {
                    if (meta.IsRequired)
                        sink.Add(el, propPath, IssueCode.RequiredMissing, null, $"Required element <{meta.XmlTag}> is missing.");
                    else if (type.IsInterface)
                        SetMember(instance, meta, CreateList(meta.Property.PropertyType, meta.CoreType, []));   // a record's list starts empty; so does this
                    continue;
                }
                var items = new List<object>();
                var allRead = true;
                for (var i = 0; i < children.Count; i++)
                {
                    var item = ReadValue(meta.CoreType, children[i], ns, $"{propPath}[{i + 1}]", sink, meta.CoreIsLeaf);
                    if (item is null) allRead = false; else items.Add(item);
                }
                if (allRead)
                    SetMember(instance, meta, CreateList(meta.Property.PropertyType, meta.CoreType, items));
            }
            else
            {
                var child = el.Element(ns + meta.XmlTag);
                if (child is null)
                {
                    if (meta.IsRequired)
                        sink.Add(el, propPath, IssueCode.RequiredMissing, null, $"Required element <{meta.XmlTag}> is missing.");
                    continue;
                }
                var value = ReadValue(propType, child, ns, propPath, sink, meta.CoreIsLeaf);
                if (value is not null)
                    SetMember(instance, meta, value);
            }
        }
        return instance;
    }

    // Returns null when the value could not be read; the reason is in the sink.
    private static object? ReadValue(Type type, XElement el, XNamespace ns, string path, ReadSink sink, bool isLeaf)
    {
        var core = UnwrapNullable(type);
        if (core.IsEnum)
            return ReadEnum(core, el, path, sink);
        if (isLeaf || IsLeafType(core))
            return ReadLeaf(core, el, path, sink);
        if (IsChoiceType(core))
            return ReadChoice(core, el, ns, path, sink);
        if (IsAmountType(core))
            return ReadAmount(core, el, path, sink);
        return ReadObject(core, el, ns, path, sink);
    }

    private static object? ReadLeaf(Type type, XElement el, string path, ReadSink sink)
    {
        try
        {
            return ParseLeaf(type, el.Value, el);
        }
        catch (Exception ex) when (IsRecognizedParseFailure(ex) || ex is TargetInvocationException)
        {
            // The struct constructors run through Activator, so their exception arrives wrapped (issue #7).
            var inner = ex is TargetInvocationException { InnerException: { } i } ? i : ex;
            // ConstructSimpleValue already wraps the format exception; its own message says which rule.
            var reason = inner.InnerException is Iso20022FormatException fmt ? fmt.Message : inner.Message;
            var code = inner is Iso20022FormatException || inner.InnerException is Iso20022FormatException
                ? IssueCode.FacetViolation
                : IssueCode.BadValue;
            sink.Add(el, path, code, el.Value, reason);
            return null;
        }
    }

    // Matches the wire value, or exactly a member name. Never a number (issue #9).
    private static object? ReadEnum(Type enumType, XElement el, string path, ReadSink sink)
    {
        var text = el.Value;
        foreach (var field in enumType.GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            var wire = field.GetCustomAttribute<EnumMemberAttribute>()?.Value ?? field.Name;
            if (wire == text || field.Name == text)
                return field.GetValue(null);
        }
        var valid = string.Join(", ", enumType.GetFields(BindingFlags.Public | BindingFlags.Static)
            .Select(f => f.GetCustomAttribute<EnumMemberAttribute>()?.Value ?? f.Name));
        sink.Add(el, path, IssueCode.BadValue, text, $"'{text}' is not a value of {enumType.Name}. Expected one of: {valid}.");
        return null;
    }

    private static object? ReadChoice(Type abstractType, XElement parentEl, XNamespace ns, string path, ReadSink sink)
    {
        var variants = GetChoiceVariants(abstractType);
        var present = variants.Where(v => parentEl.Element(ns + v.Tag) is not null).ToList();

        foreach (var child in parentEl.Elements())
            if (child.Name.Namespace != ns || !variants.Any(v => v.Tag == child.Name.LocalName))
                sink.Add(child, $"{path}/{child.Name.LocalName}", IssueCode.UnexpectedElement, null,
                    $"<{abstractType.Name}> has no variant <{child.Name.LocalName}>.");

        if (present.Count != 1)
        {
            var expected = string.Join(", ", variants.Select(v => $"<{v.Tag}>"));
            if (present.Count == 0)
                sink.Add(parentEl, path, IssueCode.UnknownChoice, null, $"None of {expected} is present (one is required).");
            else
                sink.Add(parentEl, path, IssueCode.AmbiguousChoice, null,
                    $"Only one of {expected} may be present, found {string.Join(", ", present.Select(v => $"<{v.Tag}>"))}.");
            return null;
        }

        var (tag, variantType) = present[0];
        var wrapper = parentEl.Element(ns + tag)!;
        var variantPath = $"{path}/{tag}";
        if (ClassTag(variantType) is not null)
            return IsAmountType(variantType)
                ? ReadAmount(variantType, wrapper, variantPath, sink)
                : ReadObject(variantType, wrapper, ns, variantPath, sink);

        // Simple variant: the discriminating element holds the value
        var variantProps = GetProps(variantType);
        var value = ReadValue(variantProps[0].CoreType, wrapper, ns, variantPath, sink, variantProps[0].CoreIsLeaf);
        if (value is null)
            return null;
        var instance = Create(variantType, sink);
        SetMember(instance, variantProps[0], value);
        return instance;
    }

    // <Amt Ccy="EUR">10.50</Amt>. The currency is checked by its code type (#8), the value by the facets of its amount type (#13):
    // not negative, at most so many digits in all and after the decimal point.
    private static object? ReadAmount(Type type, XElement el, string path, ReadSink sink)
    {
        var props = GetProps(type);
        var ccy = el.Attribute("Ccy")?.Value;
        var currencyProp = props.First(p => p.XmlTag == "Currency").Property;
        object? currency = ccy;
        var ok = true;
        if (string.IsNullOrEmpty(ccy))
        {
            sink.Add(el, $"{path}/@Ccy", IssueCode.RequiredMissing, null, "Required attribute Ccy is missing.");
            ok = false;
        }
        else
        {
            // the currency code types check their own pattern; a bad code is reported, not thrown
            try
            {
                currency = Activator.CreateInstance(currencyProp.PropertyType, ccy);
            }
            catch (TargetInvocationException ex) when (ex.InnerException is Iso20022FormatException fmt)
            {
                sink.Add(el.Attribute("Ccy"), $"{path}/@Ccy", IssueCode.FacetViolation, ccy, fmt.Message);
                ok = false;
            }
        }
        if (!decimal.TryParse(el.Value, NumberStyles.Number, CultureInfo.InvariantCulture, out var amount))
        {
            sink.Add(el, path, IssueCode.BadValue, el.Value, $"'{el.Value}' is not a decimal number.");
            ok = false;
        }
        else if (props.First(p => p.XmlTag == "Amount").Property.GetCustomAttribute<IsoAmountAttribute>() is { } facets
            && IsoAmountFacets.Violation(facets, amount) is { } reason)
        {
            sink.Add(el, path, IssueCode.FacetViolation, el.Value, $"'{el.Value}' is not a valid amount: {reason}.");
            ok = false;
        }
        if (!ok)
            return null;
        var instance = Create(type, sink);
        SetMember(instance, props.First(p => p.XmlTag == "Currency"), currency);
        SetMember(instance, props.First(p => p.XmlTag == "Amount"), amount);
        return instance;
    }

    // A record is created directly; an interface is made by the factory.
    private static object Create(Type type, ReadSink sink) =>
        type.IsInterface
            ? sink.Factory.Create(type)
            : Activator.CreateInstance(type)
                ?? throw new InvalidOperationException($"Cannot create instance of {type.Name}.");

    // The property of the interface has no setter; the object the factory made has one with the same name.
    private static void SetMember(object instance, PropMeta meta, object? value)
    {
        var property = meta.Property.CanWrite
            ? meta.Property
            : instance.GetType().GetProperty(meta.Property.Name, BindingFlags.Public | BindingFlags.Instance);
        if (property is null || !property.CanWrite)
            throw new InvalidOperationException(
                $"{instance.GetType().Name} has no settable property '{meta.Property.Name}', which {meta.Property.DeclaringType?.Name} requires of the object a factory makes."
            );
        property.SetValue(instance, value);
    }
}
