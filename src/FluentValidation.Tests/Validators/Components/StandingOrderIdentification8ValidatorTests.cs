// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StandingOrderIdentification8ValidatorTests
{
    private readonly StandingOrderIdentification8Validator _sut = new();

    private static CashAccount40 ValidAccount() =>
        new()
        {
            Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
            {
                Value = "DE89370400440532013000",
            },
        };

    private static StandingOrderIdentification8 ValidMessage() => new() { Account = ValidAccount() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            AccountOwner = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            },
            Identification = "STORD-001",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
