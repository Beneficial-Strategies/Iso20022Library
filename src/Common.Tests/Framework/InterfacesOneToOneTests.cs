// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Framework;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// The interfaces of BeneficialStrategies.Iso20022.Interfaces and the records of BeneficialStrategies.Iso20022.Common correspond
/// one to one (#76): each message, component, choice and choice variant has exactly one of each, in the same namespace, of the same
/// kind, and the record implements its interface itself rather than inheriting it.
/// </summary>
public class InterfacesOneToOneTests
{
    private static readonly IsoKind[] Kinds = [IsoKind.Message, IsoKind.Component, IsoKind.Choice, IsoKind.ChoiceVariant];

    private static readonly Assembly InterfacesAssembly = typeof(IGenericIdentification3).Assembly;
    private static readonly Assembly RecordsAssembly = typeof(GenericIdentification3).Assembly;

    // A choice's abstract base record carries a trailing underscore that its interface does not.
    private static string Key(Type type) => $"{type.Namespace}.{(type.IsInterface ? type.Name[1..] : type.Name).TrimEnd('_')}";

    private static List<Type> InterfacesOf(IsoKind kind) =>
        InterfacesAssembly.GetExportedTypes().Where(t => t.IsInterface && Iso.KindOf(t) == kind).ToList();

    private static List<Type> RecordsOf(IsoKind kind) =>
        RecordsAssembly.GetExportedTypes().Where(t => t.IsClass && Iso.KindOf(t) == kind).ToList();

    [Fact]
    public void EveryInterface_IsOfAKnownKind()
    {
        var unclassified = InterfacesAssembly.GetExportedTypes()
            .Where(t => t.IsInterface && (Iso.KindOf(t) is null || !Kinds.Contains(Iso.KindOf(t)!.Value)))
            .Select(t => t.FullName)
            .ToList();

        Assert.True(unclassified.Count == 0, "interfaces of no kind: " + string.Join(", ", unclassified.Take(20)));
    }

    [Theory]
    [InlineData(IsoKind.Message, 3000)]
    [InlineData(IsoKind.Component, 5000)]
    [InlineData(IsoKind.Choice, 500)]
    [InlineData(IsoKind.ChoiceVariant, 1000)]
    public void ForEveryKind_TheInterfacesAndTheRecordsCorrespondOneToOne(IsoKind kind, int atLeast)
    {
        var interfaces = InterfacesOf(kind);
        var records = RecordsOf(kind);
        var problems = new List<string>();

        foreach (var group in interfaces.GroupBy(Key).Where(g => g.Count() > 1))
            problems.Add($"{group.Key}: {group.Count()} interfaces");
        foreach (var group in records.GroupBy(Key).Where(g => g.Count() > 1))
            problems.Add($"{group.Key}: {group.Count()} records ({string.Join(", ", group.Select(t => t.Name))})");

        var recordByKey = records.GroupBy(Key).ToDictionary(g => g.Key, g => g.First());
        var interfaceByKey = interfaces.GroupBy(Key).ToDictionary(g => g.Key, g => g.First());

        foreach (var (key, @interface) in interfaceByKey)
        {
            if (!recordByKey.TryGetValue(key, out var record))
            {
                problems.Add($"{@interface.FullName}: no {kind} record");
                continue;
            }
            // The record itself names the interface; that it is only inherited from its base is not enough.
            var inherited = record.BaseType?.GetInterfaces().Contains(@interface) == true;
            if (!record.GetInterfaces().Contains(@interface) || inherited && record.BaseType!.IsAbstract == false)
                problems.Add($"{record.FullName}: does not implement {@interface.Name} itself");
        }
        foreach (var (key, record) in recordByKey)
            if (!interfaceByKey.ContainsKey(key))
                problems.Add($"{record.FullName}: no {kind} interface");

        Assert.True(interfaceByKey.Count >= atLeast, $"only {interfaceByKey.Count} {kind} interfaces, expected at least {atLeast}");
        Assert.Equal(recordByKey.Count, interfaceByKey.Count);
        Assert.True(problems.Count == 0, $"{problems.Count} problems:{Environment.NewLine}" + string.Join(Environment.NewLine, problems.Take(30)));
    }

    [Fact]
    public void NoRecordOfAKindSomeOtherInterfaceClaims_ImplementsTheInterfaceOfAnotherKind()
    {
        var problems = new List<string>();
        foreach (var record in RecordsAssembly.GetExportedTypes().Where(t => t.IsClass))
        {
            var kind = Iso.KindOf(record);
            if (kind is null || !Kinds.Contains(kind.Value)) continue;
            foreach (var @interface in record.GetInterfaces().Where(i => i.Assembly == InterfacesAssembly))
                if (Iso.KindOf(@interface) != kind && !(kind == IsoKind.ChoiceVariant && Iso.KindOf(@interface) == IsoKind.Choice))
                    problems.Add($"{record.FullName} is a {kind} but implements {@interface.Name}, a {Iso.KindOf(@interface)}");
        }
        Assert.True(problems.Count == 0, string.Join(Environment.NewLine, problems.Take(20)));
    }
}
