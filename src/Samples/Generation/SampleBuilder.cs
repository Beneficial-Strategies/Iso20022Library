// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections;
using System.Collections.Concurrent;
using System.Globalization;
using System.Reflection;

namespace BeneficialStrategies.Iso20022.Samples;

/// <summary>Builds the objects of <see cref="IsoSample"/> from an interface, through the factory.</summary>
internal static class SampleBuilder
{
    private static readonly ConcurrentDictionary<Type, object?> Primitives = new();
    private static readonly ConcurrentDictionary<Type, Type[]> Variants = new();
    private static readonly ConcurrentDictionary<Assembly, Dictionary<Type, Type[]>> VariantsByChoice = new();
    private static readonly ConcurrentDictionary<Type, Func<object>?> Named = new();
    private static readonly ConcurrentDictionary<Type, Member[]> Plans = new();
    private static readonly ConcurrentDictionary<Type, IsoKind?> Kinds = new();

    /// <summary>The names of types of <c>System</c> that a sample is not allowed to share (see the standard for samples).</summary>
    private static readonly HashSet<string> SystemNames = new(StringComparer.Ordinal)
    {
        "DateTime", "Decimal", "Index", "Range", "Single", "Type", "ValueType",
    };

    /// <summary>An object of the interface: the named sample if there is one, otherwise made from the interface.</summary>
    /// <param name="type">The interface.</param>
    /// <param name="path">The interfaces being built above this one, to stop a loop.</param>
    /// <param name="where">Where in the object this is, for a message.</param>
    internal static object Build(Type type, List<Type> path, string where)
    {
        var named = Named.GetOrAdd(type, FindNamedSample);
        if (named is not null)
            return named();
        if (KindOf(type) == IsoKind.Choice)
            return BuildChoice(type, path, where);
        if (path.Contains(type))
            throw new InvalidOperationException($"{where}: '{type.Name}' contains itself through required members, so no object of it can be made from its shape. Write a named sample for it.");
        path.Add(type);
        try
        {
            var instance = IsoDataFactory.Shared.Create(type);
            foreach (var member in Plans.GetOrAdd(type, t => RequiredMembers(t, instance.GetType())))
                member.Target.SetValue(instance, Value(member.Type, path, $"{where}.{member.Name}"));
            return instance;
        }
        finally
        {
            path.RemoveAt(path.Count - 1);
        }
    }

    private sealed record Member(string Name, Type Type, PropertyInfo Target);

    /// <summary>The members to set for an interface, found once: its required members, with the property of the generated class that holds each.</summary>
    private static Member[] RequiredMembers(Type type, Type generated) =>
        type.GetProperties()
            .Where(p => !Nullability.IsOptional(p))
            .Select(p => new Member(p.Name, p.PropertyType, generated.GetProperty(p.Name)
                ?? throw new InvalidOperationException($"{type.Name}.{p.Name}: the generated class has no such member.")))
            .ToArray();

    private static IsoKind? KindOf(Type type) => Kinds.GetOrAdd(type, t => Iso.KindOf(t));

    private static object BuildChoice(Type choice, List<Type> path, string where)
    {
        var variants = Variants.GetOrAdd(choice, FindVariants);
        if (variants.Length == 0)
            throw new InvalidOperationException($"{where}: the choice '{choice.Name}' has no variant.");
        return Build(variants[0], path, where);
    }

    private static Type[] FindVariants(Type choice) =>
        VariantsByChoice.GetOrAdd(choice.Assembly, VariantsOfAssembly).TryGetValue(choice, out var variants) ? variants : [];

    /// <summary>Every choice of an assembly with its variants in order of name, found in one pass (a scan per choice would be 4,000 scans of 34,000 types).</summary>
    private static Dictionary<Type, Type[]> VariantsOfAssembly(Assembly assembly)
    {
        var found = new Dictionary<Type, List<Type>>();
        foreach (var type in assembly.GetTypes())
        {
            if (!type.IsInterface || !type.IsPublic || Iso.KindOf(type) != IsoKind.ChoiceVariant)
                continue;
            foreach (var parent in type.GetInterfaces())
            {
                if (Iso.KindOf(parent) != IsoKind.Choice)
                    continue;
                if (!found.TryGetValue(parent, out var list))
                    found[parent] = list = new List<Type>();
                list.Add(type);
            }
        }
        return found.ToDictionary(f => f.Key, f => f.Value.OrderBy(t => t.Name, StringComparer.Ordinal).ToArray());
    }

    private static object Value(Type type, List<Type> path, string where)
    {
        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(IEnumerable<>))
        {
            var item = type.GetGenericArguments()[0];
            var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(item))!;
            list.Add(Value(item, path, where + "[0]"));
            return list;
        }
        if (type == typeof(string))
            return "A";
        if (type.IsPrimitive || type == typeof(decimal))
            return Values(type).FirstOrDefault() ?? throw new InvalidOperationException($"{where}: no value of '{type.Name}' could be found.");
        return KindOf(type) switch
        {
            IsoKind.Component or IsoKind.Choice or IsoKind.ChoiceVariant or IsoKind.Message => Build(type, path, where),
            _ => Primitive(type) ?? throw new InvalidOperationException($"{where}: no value of '{type.Name}' could be found. Write a named sample for the type that contains it."),
        };
    }

    // ---- named samples: Samples.<Type>.Valid.Standard (a variant: Samples.<Choice>.Valid.<Variant>), property Minimal ----

    private static Func<object>? FindNamedSample(Type type)
    {
        var kind = Iso.KindOf(type);
        string? typeName;
        string? scenario;
        if (kind == IsoKind.ChoiceVariant)
        {
            typeName = type.Namespace?.Substring(type.Namespace.LastIndexOf('.') + 1);
            scenario = Unprefixed(type.Name);
            if (SystemNames.Contains(scenario))
                scenario += "_";
        }
        else if (kind is IsoKind.Component or IsoKind.Message)
        {
            typeName = Unprefixed(type.Name);
            scenario = "Standard";
        }
        else
        {
            return null;
        }
        if (typeName is null)
            return null;
        var sampleClass = typeof(SampleBuilder).Assembly.GetType($"BeneficialStrategies.Iso20022.Samples.{typeName}.Valid.{scenario}", throwOnError: false);
        var minimal = sampleClass?.GetProperty("Minimal", BindingFlags.Public | BindingFlags.Static);
        if (minimal is null || !type.IsAssignableFrom(minimal.PropertyType))
            return null;
        return () => minimal.GetValue(null)!;
    }

    private static string Unprefixed(string interfaceName) => interfaceName.Length > 1 && interfaceName[0] == 'I' ? interfaceName.Substring(1) : interfaceName;

    // ---- primitives: simple types, external codes, amounts and code sets ----

    private static object? Primitive(Type type)
    {
        type = Nullable.GetUnderlyingType(type) ?? type;
        return Primitives.GetOrAdd(type, FindPrimitive);
    }

    private static object? FindPrimitive(Type type)
    {
        if (type.IsEnum)
            return Enum.GetValues(type).GetValue(0);
        if (typeof(IIsoOpenContent).IsAssignableFrom(type))
            return Activator.CreateInstance(type);
        var currency = type.GetProperty("Currency");
        var amount = type.GetProperty("Amount");
        if (currency is not null && amount is not null && typeof(IIsoAmount).IsAssignableFrom(type))
            return FindAmount(type, currency, amount);
        var tryCreate = type.GetMethod("TryCreate", BindingFlags.Public | BindingFlags.Static, null, [typeof(string), type.MakeByRefType()], null);
        if (tryCreate is not null)
        {
            foreach (var text in Texts(type))
            {
                var args = new object?[] { text, null };
                if ((bool)tryCreate.Invoke(null, args)!)
                    return args[1];
            }
        }
        foreach (var constructor in type.GetConstructors().Where(c => c.GetParameters().Length >= 1 && c.GetParameters().Skip(1).All(p => p.IsOptional)))
        {
            var parameters = constructor.GetParameters();
            foreach (var value in Values(parameters[0].ParameterType))
            {
                try
                {
                    return constructor.Invoke(new[] { value }.Concat(parameters.Skip(1).Select(p => p.DefaultValue)).ToArray());
                }
                catch (TargetInvocationException)
                {
                }
            }
        }
        return null;
    }

    private static object? FindAmount(Type type, PropertyInfo currency, PropertyInfo amount)
    {
        var code = Primitive(currency.PropertyType);
        if (code is null)
            return null;
        foreach (var value in new[] { 100m, 1m, 10m })
        {
            try
            {
                var instance = Activator.CreateInstance(type)!;
                currency.SetValue(instance, code);
                amount.SetValue(instance, Convert.ChangeType(value, Nullable.GetUnderlyingType(amount.PropertyType) ?? amount.PropertyType, CultureInfo.InvariantCulture));
                return instance;
            }
            catch (TargetInvocationException)
            {
            }
        }
        return null;
    }

    private static IEnumerable<string> Texts(Type type)
    {
        const BindingFlags any = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
        foreach (var name in new[] { "Pattern", "CorePattern" })
        {
            var pattern = type.GetField(name, any)?.GetRawConstantValue() as string;
            if (pattern is null)
                continue;
            foreach (var extra in new[] { 0, 1, 2 })
            {
                var sample = PatternSampler.Sample(pattern, extra);
                if (sample is not null)
                    yield return sample;
            }
        }
        var min = type.GetField("MinLength", BindingFlags.Public | BindingFlags.Static)?.GetRawConstantValue() as int? ?? 1;
        var max = type.GetField("MaxLength", BindingFlags.Public | BindingFlags.Static)?.GetRawConstantValue() as int? ?? 35;
        yield return new string('A', Math.Max(min, 1));
        yield return new string('1', Math.Max(min, 1));
        yield return new string('A', Math.Min(max, Math.Max(min, 4)));
        yield return "2026-01-01T00:00:00";
        yield return "2026-01-01";
        yield return "12:00:00";
    }

    private static IEnumerable<object> Values(Type type)
    {
        if (type == typeof(decimal)) { yield return 1m; yield return 100m; yield return 0m; }
        else if (type == typeof(long) || type == typeof(int) || type == typeof(short) || type == typeof(sbyte)
            || type == typeof(ulong) || type == typeof(uint) || type == typeof(ushort) || type == typeof(byte))
        {
            yield return Convert.ChangeType(1, type, CultureInfo.InvariantCulture);
            yield return Convert.ChangeType(0, type, CultureInfo.InvariantCulture);
        }
        else if (type == typeof(bool)) yield return true;
        else if (type == typeof(DateTime)) yield return new DateTime(2026, 1, 1);
        else if (type == typeof(TimeSpan)) yield return TimeSpan.Zero;
        else if (type == typeof(string)) yield return "A";
        else if (type.FullName is "System.DateOnly") yield return Activator.CreateInstance(type, 2026, 1, 1)!;
        else if (type.FullName is "System.TimeOnly") yield return Activator.CreateInstance(type, 12, 0, 0)!;
        else if (type.FullName is "System.DateTimeOffset") yield return new DateTimeOffset(2026, 1, 1, 0, 0, 0, TimeSpan.Zero);
    }
}
