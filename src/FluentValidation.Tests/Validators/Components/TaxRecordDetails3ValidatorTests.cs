// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxRecordDetails3ValidatorTests
{
    private readonly TaxRecordDetails3Validator _sut = new();

    private static TaxRecordDetails3 ValidMessage() =>
        new() { Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m } };

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
            Period = new TaxPeriod3 { Year = 2026 },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
