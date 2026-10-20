// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TaxAmount3ValidatorTests
{
    private readonly TaxAmount3Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new TaxAmount3()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new TaxAmount3
        {
            Rate = 5.5m,
            TaxableBaseAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 1000m },
            TotalAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 55m },
            Details =
            [
                new TaxRecordDetails3
                {
                    Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 55m },
                },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
