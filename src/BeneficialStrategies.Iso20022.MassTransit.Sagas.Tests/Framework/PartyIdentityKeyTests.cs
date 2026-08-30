// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using Party53Choice = BeneficialStrategies.Iso20022.Choices.Party53Choice;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.Framework;

public class PartyIdentityKeyTests
{
    [Fact]
    public void Null_ReturnsNull()
    {
        Assert.Null(PartyIdentityKey.From(null));
    }

    [Fact]
    public void Organisation_LEIPresent_TakesPriorityOverAnyBIC()
    {
        var party = new Party53Choice.OrganisationIdentification
        {
            Value = new OrganisationIdentification40
            {
                LEI = "529900T8BM49AURSDO55",
                AnyBIC = "DEUTDEFF",
            },
        };

        Assert.Equal("LEI:529900T8BM49AURSDO55", PartyIdentityKey.From(party));
    }

    [Fact]
    public void Organisation_AnyBICPresent_NoLEI_UsesAnyBIC()
    {
        var party = new Party53Choice.OrganisationIdentification
        {
            Value = new OrganisationIdentification40 { AnyBIC = "DEUTDEFF" },
        };

        Assert.Equal("BIC:DEUTDEFF", PartyIdentityKey.From(party));
    }

    [Fact]
    public void Organisation_OnlyOther_UsesFirstOtherEntry()
    {
        var party = new Party53Choice.OrganisationIdentification
        {
            Value = new OrganisationIdentification40
            {
                Other =
                [
                    new GenericOrganisationIdentification3 { Identification = "ACME-001" },
                    new GenericOrganisationIdentification3 { Identification = "ACME-002" },
                ],
            },
        };

        Assert.Equal("OTHER:ACME-001", PartyIdentityKey.From(party));
    }

    [Fact]
    public void Organisation_NothingPopulated_ReturnsNull()
    {
        var party = new Party53Choice.OrganisationIdentification
        {
            Value = new OrganisationIdentification40(),
        };

        Assert.Null(PartyIdentityKey.From(party));
    }

    [Fact]
    public void Person_OnlyOther_UsesFirstOtherEntry()
    {
        var party = new Party53Choice.PrivateIdentification
        {
            Value = new PersonIdentification20
            {
                Other = [new GenericPersonIdentification2 { Identification = "PERSON-001" }],
            },
        };

        Assert.Equal("OTHER:PERSON-001", PartyIdentityKey.From(party));
    }

    [Fact]
    public void Person_NothingPopulated_ReturnsNull()
    {
        var party = new Party53Choice.PrivateIdentification
        {
            Value = new PersonIdentification20(),
        };

        Assert.Null(PartyIdentityKey.From(party));
    }
}
