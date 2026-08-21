// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentIdentification6ValidatorTests
{
    private readonly PaymentIdentification6Validator _sut = new();

    private static PaymentIdentification6 ValidMessage() => new() { EndToEndIdentification = "E2E-001" };

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
            InstructionIdentification = "INSTR-001",
            UETR = "3f2504e0-4f89-4c1a-a1a1-4f89c1a1a1a1",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
