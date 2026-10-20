// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class LimitStructure6ValidatorTests
{
    private readonly LimitStructure6Validator _sut = new();

    private static LimitIdentification8 ValidLimitIdentification() =>
        new()
        {
            Type = new BeneficialStrategies.Iso20022.Choices.LimitType1Choice.Code
            {
                Value = LimitType3Code.Bilateral,
            },
        };

    private static BeneficialStrategies.Iso20022.Choices.Amount2Choice_ ValidAmount() =>
        new BeneficialStrategies.Iso20022.Choices.Amount2Choice.AmountWithCurrency { Currency = "USD", Amount = 100m };

    private static LimitStructure6 ValidMessage() =>
        new() { LimitIdentification = ValidLimitIdentification(), Amount = ValidAmount() };

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
            CreditDebitIndicator = CreditDebitCode.Credit,
            StartDateTime = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
            {
                Value = new DateOnly(2026, 1, 1),
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
