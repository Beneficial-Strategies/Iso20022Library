// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Charges16ValidatorTests
{
    private readonly Charges16Validator _sut = new();

    private static Charges16 ValidMessage() =>
        new()
        {
            Agent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
            },
            Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 10m },
        };

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
            Type = new BeneficialStrategies.Iso20022.Choices.ChargeType3Choice.Proprietary
            {
                Identification = "CHG-001",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
