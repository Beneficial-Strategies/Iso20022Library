// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022;

/// <summary>Spike for #27: the pacs records implement their interfaces, and a foreign class can stand in for one.</summary>
public class PacsInterfacesSpikeTests
{
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
        Assert.Equal(IsoKind.Component, Iso.KindOf(record.GetType()));
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
    public void EveryPacsRecord_ImplementsItsInterface_AndHasTheKindItsMarkerSays()
    {
        var records = typeof(GenericIdentification3)
            .Assembly.GetTypes()
            .Where(t => t.IsPublic && t.Namespace is not null && t.Name != "" && !t.IsInterface)
            .Where(t => t.GetInterfaces().Any(i => i.Namespace == t.Namespace && i.Name == "I" + t.Name.TrimEnd('_')))
            .ToList();
        Assert.True(records.Count >= 98 + 450 + 70 + 165, $"only {records.Count} records implement an interface of their name");

        foreach (var t in records)
        {
            var expected = t.GetInterfaces().Contains(typeof(IIsoChoiceVariant))
                ? IsoKind.ChoiceVariant
                : t.GetInterfaces().Contains(typeof(IIsoChoice))
                    ? IsoKind.Choice
                    : t.GetInterfaces().Contains(typeof(IIsoComponent))
                        ? IsoKind.Component
                        : IsoKind.Message;
            Assert.Equal(expected, Iso.KindOf(t));
        }
    }
}
