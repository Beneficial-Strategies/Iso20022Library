// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Framework;
using BeneficialStrategies.Iso20022.Metadata;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022;

/// <summary>The interfaces of BeneficialStrategies.Iso20022.Interfaces (#27) and the records that implement them.</summary>
public class InterfacesTests
{
    private static readonly Assembly InterfacesAssembly = typeof(IGenericIdentification3).Assembly;
    private static readonly Assembly RecordsAssembly = typeof(GenericIdentification3).Assembly;

    private static readonly Type[] Interfaces = InterfacesAssembly.GetExportedTypes().Where(t => t.IsInterface).ToArray();

    // ── a class of someone else can stand in for a record ──────────────────────

    private sealed class MyIdentification : IGenericIdentification3
    {
        public Max35Text Identification => "MINE-1";
        public Max35Text? Issuer => null;
    }

    private static string Describe(IGenericIdentification3 id) => $"{id.Identification}/{id.Issuer?.ToString() ?? "-"}";

    [Fact]
    public void ARecordAndAForeignClass_AreBothAcceptedWhereTheInterfaceIsAsked()
    {
        var record = new GenericIdentification3 { Identification = "REC-9", Issuer = "BANK" };
        Assert.Equal("REC-9/BANK", Describe(record));
        Assert.Equal("MINE-1/-", Describe(new MyIdentification()));
        Assert.Equal(IsoKind.Component, Iso.KindOf(typeof(IGenericIdentification3)));
    }

    [Fact]
    public void ARecordWithAComponentMember_ExposesItThroughTheInterface()
    {
        var record = new BranchAndFinancialInstitutionIdentification6
        {
            FinancialInstitutionIdentification = new FinancialInstitutionIdentification18 { BICFI = "DEUTDEFF" },
        };
        IBranchAndFinancialInstitutionIdentification6 viaInterface = record;
        Assert.Same(record.FinancialInstitutionIdentification, viaInterface.FinancialInstitutionIdentification);
        Assert.Null(viaInterface.BranchIdentification);
    }

    [Fact]
    public void AListOfComponents_IsSeenAsAnEnumerableOfTheirInterface()
    {
        var message = new BeneficialStrategies.Iso20022.pacs.FIToFICustomerCreditTransferV13
        {
            GroupHeader = new GroupHeader131
            {
                MessageIdentification = "M",
                CreationDateTime = new ISODateTime(new DateTime(2026, 1, 1)),
                NumberOfTransactions = "1",
                SettlementInformation = new SettlementInstruction15 { SettlementMethod = Codesets.SettlementMethod1Code.InstructedAgent },
            },
            CreditTransferTransactionInformation = [],
        };
        BeneficialStrategies.Iso20022.pacs.IFIToFICustomerCreditTransferV13 viaInterface = message;
        Assert.Empty(viaInterface.CreditTransferTransactionInformation);
        Assert.Equal("M", (string)viaInterface.GroupHeader.MessageIdentification);
        Assert.IsAssignableFrom<IOuterRecord>(viaInterface);
        Assert.Equal(IsoKind.Message, Iso.KindOf(typeof(BeneficialStrategies.Iso20022.pacs.IFIToFICustomerCreditTransferV13)));
    }

    // ── every interface has an implementer, of the kind its marker says ───────

    private static IEnumerable<Type> Implementers(Type @interface) =>
        RecordsAssembly.GetExportedTypes().Where(t => t.IsClass && @interface.IsAssignableFrom(t));

    [Fact]
    public void EveryInterface_IsImplementedByARecordOfThatName_OfTheKindItsMarkerSays()
    {
        Assert.True(Interfaces.Length > 100, $"only {Interfaces.Length} interfaces");
        var problems = new List<string>();
        foreach (var @interface in Interfaces)
        {
            var name = @interface.Name[1..];
            var records = Implementers(@interface).Where(t => t.Name.TrimEnd('_') == name).ToList();
            if (records.Count == 0)
            {
                problems.Add($"{@interface.FullName}: no record {name} implements it");
                continue;
            }
            var expected = @interface.GetInterfaces().Contains(typeof(IIsoChoiceVariant)) ? IsoKind.ChoiceVariant
                : @interface.GetInterfaces().Contains(typeof(IIsoChoice)) ? IsoKind.Choice
                : @interface.GetInterfaces().Contains(typeof(IIsoComponent)) ? IsoKind.Component
                : IsoKind.Message;
            foreach (var record in records)
                if (Iso.KindOf(record) != expected)
                    problems.Add($"{record.FullName}: {Iso.KindOf(record)}, expected {expected}");
        }
        Assert.True(problems.Count == 0, string.Join(Environment.NewLine, problems.Take(20)));
    }

    // ── what the interface says about a member is what the record says ────────

    [Fact]
    public void AnInterfaceMember_HasTheIsoIdAndTheXmlTagOfTheRecordMember()
    {
        var problems = new List<string>();
        foreach (var @interface in Interfaces)
        {
            var record = Implementers(@interface).FirstOrDefault(t => t.Name.TrimEnd('_') == @interface.Name[1..] && !t.IsAbstract);
            if (record is null) continue;
            foreach (var member in @interface.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                var onRecord = record.GetProperty(member.Name);
                if (onRecord is null) { problems.Add($"{record.Name}.{member.Name}: missing"); continue; }
                if (member.GetCustomAttribute<IsoIdAttribute>()?.Id != onRecord.GetCustomAttribute<IsoIdAttribute>()?.Id)
                    problems.Add($"{record.Name}.{member.Name}: IsoId differs");
                if (member.GetCustomAttribute<IsoXmlTagAttribute>()?.XmlTag != onRecord.GetCustomAttribute<IsoXmlTagAttribute>()?.XmlTag)
                    problems.Add($"{record.Name}.{member.Name}: XML tag differs");
            }
        }
        Assert.True(problems.Count == 0, string.Join(Environment.NewLine, problems.Take(20)));
    }

    [Fact]
    public void ARequiredMemberIsNotNullable_AnOptionalOneIs_AListIsAnEnumerable()
    {
        var problems = new List<string>();
        var nullability = new NullabilityInfoContext();
        foreach (var @interface in Interfaces)
        {
            var record = Implementers(@interface).FirstOrDefault(t => t.Name.TrimEnd('_') == @interface.Name[1..] && !t.IsAbstract);
            if (record is null) continue;
            foreach (var member in @interface.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                var onRecord = record.GetProperty(member.Name)!;
                var required = onRecord.GetCustomAttribute<System.Runtime.CompilerServices.RequiredMemberAttribute>() is not null;
                var isList = member.PropertyType.IsGenericType && member.PropertyType.GetGenericTypeDefinition() == typeof(IEnumerable<>);
                var recordIsList = onRecord.PropertyType.IsGenericType && onRecord.PropertyType.Name.Contains("ValueList");
                if (isList != recordIsList) { problems.Add($"{record.Name}.{member.Name}: list on one side only"); continue; }
                if (isList) continue;
                var nullable = Nullable.GetUnderlyingType(member.PropertyType) is not null
                    || nullability.Create(member).ReadState == NullabilityState.Nullable;
                if (nullable == required)
                    problems.Add($"{record.Name}.{member.Name}: {(required ? "required" : "optional")} on the record, {(nullable ? "nullable" : "not nullable")} on the interface");
            }
        }
        Assert.True(problems.Count == 0, string.Join(Environment.NewLine, problems.Take(20)));
    }

    [Fact]
    public void EveryChoiceVariantInterface_CarriesTheWrapperTagOfItsRecord()
    {
        // A reader that has only the interfaces finds a variant by this tag.
        var problems = new List<string>();
        var variants = RecordsAssembly.GetExportedTypes()
            .Where(t => t.IsClass && typeof(IIsoChoiceVariant).IsAssignableFrom(t) && t.GetCustomAttribute<IsoXmlTagAttribute>() is not null);
        foreach (var record in variants)
        {
            var wanted = record.GetCustomAttribute<IsoXmlTagAttribute>()!.XmlTag;
            var iface = Interfaces.FirstOrDefault(i => i.Name == "I" + record.Name && i.Namespace == record.Namespace);
            var actual = iface?.GetCustomAttribute<IsoXmlTagAttribute>()?.XmlTag;
            if (actual != wanted)
                problems.Add($"{record.FullName}: record <{wanted}>, interface <{actual ?? "none"}>");
        }
        Assert.True(problems.Count == 0, string.Join(Environment.NewLine, problems.Take(20)));
    }

    [Fact]
    public void EveryMessageRecord_HasAnInterfaceItImplements()
    {
        var problems = new List<string>();
        foreach (var record in RecordsAssembly.GetExportedTypes().Where(t => t.IsClass && typeof(IOuterRecord).IsAssignableFrom(t)))
        {
            var iface = Interfaces.FirstOrDefault(i => i.Name == "I" + record.Name && i.Namespace == record.Namespace);
            if (iface is null) problems.Add($"{record.FullName}: no interface");
            else if (!iface.IsAssignableFrom(record)) problems.Add($"{record.FullName}: does not implement {iface.Name}");
        }
        Assert.True(problems.Count == 0, string.Join(Environment.NewLine, problems.Take(20)));
    }
}
