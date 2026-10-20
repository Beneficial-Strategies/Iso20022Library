// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentCondition2ValidatorTests
{
    private readonly PaymentCondition2Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IPaymentCondition2>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IPaymentCondition2>(b => b
            .Set(x => x.AmountModificationAllowed).To(true)
            .Set(x => x.DelayPenalty).To("Late fee applies")
            .Set(x => x.EarlyPaymentAllowed).To(false)
            .Set(x => x.GuaranteedPaymentRequested).To(true)
            .Set(x => x.ImmediatePaymentRebate).To(IsoDataFactory.Make<Choices.AmountOrRate1Choice.IRate>(b2 => b2
                .Set(x2 => x2.Value).To(2.5m))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
