// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentConditionStatus2ValidatorTests
{
    private readonly PaymentConditionStatus2Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new PaymentConditionStatus2()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new PaymentConditionStatus2
        {
            AcceptedAmount = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m },
            EarlyPayment = true,
            GuaranteedPayment = false,
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
