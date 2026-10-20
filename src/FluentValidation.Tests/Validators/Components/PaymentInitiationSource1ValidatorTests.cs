// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentInitiationSource1ValidatorTests
{
    private readonly PaymentInitiationSource1Validator _sut = new();

    private static IPaymentInitiationSource1 ValidMessage() => IsoDataFactory.Make<IPaymentInitiationSource1>(b => b
        .Set(x => x.Name).To("MyPaymentApp"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Provider).To("MyProvider")
            .Set(x => x.Version).To("1.0"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
