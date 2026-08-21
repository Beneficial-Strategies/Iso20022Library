// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class RemittanceAmount4ValidatorTests
{
    private readonly RemittanceAmount4Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new RemittanceAmount4()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new RemittanceAmount4
        {
            AdjustmentAmountAndReason =
            [
                new DocumentAdjustment1
                {
                    Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 10m },
                },
            ],
            RemittanceAmountAndType =
            [
                new DocumentAmount1
                {
                    Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
                    Type = new BeneficialStrategies.Iso20022.Choices.DocumentAmountType1Choice.Proprietary
                    {
                        Value = "MYAMTTYPE",
                    },
                },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
