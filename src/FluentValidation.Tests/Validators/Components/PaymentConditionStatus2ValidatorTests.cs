// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentConditionStatus2ValidatorTests
{
    private readonly PaymentConditionStatus2Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IPaymentConditionStatus2>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentConditionStatus2>(b => b
            .Set(x => x.AcceptedAmount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.EarlyPayment).To(true)
            .Set(x => x.GuaranteedPayment).To(false));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
