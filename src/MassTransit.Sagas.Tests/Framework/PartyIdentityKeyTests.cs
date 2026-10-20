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
        var party = IsoDataFactory.Make<Party53Choice.IOrganisationIdentification>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IOrganisationIdentification40>(b2 => b2
                .Set(x2 => x2.LEI).To("529900T8BM49AURSDO55")
                .Set(x2 => x2.AnyBIC).To("DEUTDEFF"))));

        Assert.Equal("LEI:529900T8BM49AURSDO55", PartyIdentityKey.From(party));
    }

    [Fact]
    public void Organisation_AnyBICPresent_NoLEI_UsesAnyBIC()
    {
        var party = IsoDataFactory.Make<Party53Choice.IOrganisationIdentification>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IOrganisationIdentification40>(b2 => b2
                .Set(x2 => x2.AnyBIC).To("DEUTDEFF"))));

        Assert.Equal("BIC:DEUTDEFF", PartyIdentityKey.From(party));
    }

    [Fact]
    public void Organisation_OnlyOther_UsesFirstOtherEntry()
    {
        var party = IsoDataFactory.Make<Party53Choice.IOrganisationIdentification>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IOrganisationIdentification40>(b2 => b2
                .Set(x2 => x2.Other).To([
                    IsoDataFactory.Make<IGenericOrganisationIdentification3>(b3 => b3
                        .Set(x3 => x3.Identification).To("ACME-001")),
                    IsoDataFactory.Make<IGenericOrganisationIdentification3>(b3 => b3
                        .Set(x3 => x3.Identification).To("ACME-002")),
                ]))));

        Assert.Equal("OTHER:ACME-001", PartyIdentityKey.From(party));
    }

    [Fact]
    public void Organisation_NothingPopulated_ReturnsNull()
    {
        var party = IsoDataFactory.Make<Party53Choice.IOrganisationIdentification>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IOrganisationIdentification40>()));

        Assert.Null(PartyIdentityKey.From(party));
    }

    [Fact]
    public void Person_OnlyOther_UsesFirstOtherEntry()
    {
        var party = IsoDataFactory.Make<Party53Choice.IPrivateIdentification>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IPersonIdentification20>(b2 => b2
                .Set(x2 => x2.Other).To([IsoDataFactory.Make<IGenericPersonIdentification2>(b3 => b3
                    .Set(x3 => x3.Identification).To("PERSON-001"))]))));

        Assert.Equal("OTHER:PERSON-001", PartyIdentityKey.From(party));
    }

    [Fact]
    public void Person_NothingPopulated_ReturnsNull()
    {
        var party = IsoDataFactory.Make<Party53Choice.IPrivateIdentification>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IPersonIdentification20>()));

        Assert.Null(PartyIdentityKey.From(party));
    }
}
