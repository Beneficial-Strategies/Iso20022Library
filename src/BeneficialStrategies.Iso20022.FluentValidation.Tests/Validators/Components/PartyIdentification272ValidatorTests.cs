// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PartyIdentification272ValidatorTests
{
    private readonly PartyIdentification272Validator _sut = new();

    private static PartyIdentification272 ValidMessage() => new() { Name = "Acme Corp" };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            ContactDetails = new Contact13 { Name = "Jane Doe" },
            Identification = new BeneficialStrategies.Iso20022.Choices.Party52Choice.OrganisationIdentification
            {
                Value = new OrganisationIdentification39(),
            },
            PostalAddress = new PostalAddress27 { TownName = "Springfield" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
