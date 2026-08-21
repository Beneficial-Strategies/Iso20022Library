// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentCondition2ValidatorTests
{
    private readonly PaymentCondition2Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new PaymentCondition2()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new PaymentCondition2
        {
            AmountModificationAllowed = true,
            DelayPenalty = "Late fee applies",
            EarlyPaymentAllowed = false,
            GuaranteedPaymentRequested = true,
            ImmediatePaymentRebate = new BeneficialStrategies.Iso20022.Choices.AmountOrRate1Choice.Rate
            {
                Value = 2.5m,
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
