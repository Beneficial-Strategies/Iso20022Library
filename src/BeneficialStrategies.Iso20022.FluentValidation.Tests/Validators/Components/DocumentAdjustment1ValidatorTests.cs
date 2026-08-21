// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DocumentAdjustment1ValidatorTests
{
    private readonly DocumentAdjustment1Validator _sut = new();

    private static DocumentAdjustment1 ValidMessage() =>
        new() { Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 10m } };

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
            Reason = "ADJ1",
            AdditionalInformation = "Adjustment note",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
