// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Concurrent;

namespace BeneficialStrategies.Iso20022.Factory;

/// <summary>What a message interface reaches: its components, its choices and their variants.</summary>
internal static class InterfaceGraph
{
    private static readonly ConcurrentDictionary<Assembly, ILookup<Type, Type>> VariantsByAssembly =
        new();

    /// <summary>The properties of an interface and of the interfaces it extends.</summary>
    public static IEnumerable<PropertyInfo> Properties(Type iface) =>
        new[] { iface }
            .Concat(iface.GetInterfaces())
            .SelectMany(i => i.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            .GroupBy(p => p.Name)
            .Select(g => g.First());

    /// <summary>Whether the interface is one of the library's shapes: a message, a component, a choice or a variant.</summary>
    public static bool IsIsoInterface(Type t) =>
        t.IsInterface
        && (
            typeof(IOuterRecord).IsAssignableFrom(t)
            || typeof(IIsoComponent).IsAssignableFrom(t)
            || typeof(IIsoChoice).IsAssignableFrom(t)
            || typeof(IIsoChoiceVariant).IsAssignableFrom(t)
        );

    public static bool IsChoice(Type t) => t.IsInterface && typeof(IIsoChoice).IsAssignableFrom(t);

    /// <summary>The variant interfaces of a choice interface, among the types of the choice's own assembly.</summary>
    public static IEnumerable<Type> VariantsOf(Type choice) =>
        VariantsByAssembly.GetOrAdd(choice.Assembly, Index)[choice];

    private static ILookup<Type, Type> Index(Assembly assembly)
    {
        Type[] types;
        try
        {
            types = assembly.GetTypes();
        }
        catch (ReflectionTypeLoadException ex)
        {
            types = ex.Types.Where(t => t is not null).ToArray()!;
        }
        return types
            .Where(t => t.IsInterface && typeof(IIsoChoiceVariant).IsAssignableFrom(t))
            .SelectMany(v =>
                v.GetInterfaces()
                    .Where(i => i != typeof(IIsoChoice) && typeof(IIsoChoice).IsAssignableFrom(i))
                    .Select(c => (Choice: c, Variant: v))
            )
            .ToLookup(x => x.Choice, x => x.Variant);
    }

    /// <summary>
    /// Every interface that needs a class when <paramref name="root"/> is read: the root, its components, and the
    /// variants of its choices (the choice interfaces themselves need none).
    /// </summary>
    public static IReadOnlyCollection<Type> Closure(Type root)
    {
        var seen = new HashSet<Type>();
        Visit(root, seen);
        return seen.Where(t => !IsChoice(t)).ToList();
    }

    private static void Visit(Type type, HashSet<Type> seen)
    {
        if (!IsIsoInterface(type) || !seen.Add(type))
            return;
        if (IsChoice(type))
        {
            foreach (var variant in VariantsOf(type))
                Visit(variant, seen);
            return;
        }
        foreach (var property in Properties(type))
        {
            var t = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
            if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                t = t.GetGenericArguments()[0];
            Visit(t, seen);
        }
    }
}
