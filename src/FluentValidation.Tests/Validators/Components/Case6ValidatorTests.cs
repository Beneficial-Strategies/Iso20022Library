// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Case6ValidatorTests
{
    private readonly Case6Validator _sut = new();

    private static Case6 ValidMessage() =>
        new()
        {
            Identification = "CASE-001",
            Creator = new BeneficialStrategies.Iso20022.Choices.Party50Choice.Party
            {
                Value = new PartyIdentification272 { Name = "Acme Corp" },
            },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ReopenCaseIndication_Present_NoValidationError()
    {
        var msg = ValidMessage() with { ReopenCaseIndication = true };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
