// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PartyIdentification272ValidatorTests
{
    private readonly PartyIdentification272Validator _sut = new();

    private static IPartyIdentification272 ValidMessage() => IsoDataFactory.Make<IPartyIdentification272>(b => b
        .Set(x => x.Name).To("Acme Corp"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ContactDetails).To(IsoDataFactory.Make<IContact13>(b2 => b2
                .Set(x2 => x2.Name).To("Jane Doe")))
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.Party52Choice.IOrganisationIdentification>(b2 => b2
                .Set(x2 => x2.Value).To(IsoDataFactory.Make<IOrganisationIdentification39>())))
            .Set(x => x.PostalAddress).To(IsoDataFactory.Make<IPostalAddress27>(b2 => b2
                .Set(x2 => x2.TownName).To("Springfield"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
