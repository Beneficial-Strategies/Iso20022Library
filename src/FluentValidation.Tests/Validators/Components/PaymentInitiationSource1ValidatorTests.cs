// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentInitiationSource1ValidatorTests
{
    private readonly PaymentInitiationSource1Validator _sut = new();

    private static PaymentInitiationSource1 ValidMessage() => new() { Name = "MyPaymentApp" };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = ValidMessage() with { Provider = "MyProvider", Version = "1.0" };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
