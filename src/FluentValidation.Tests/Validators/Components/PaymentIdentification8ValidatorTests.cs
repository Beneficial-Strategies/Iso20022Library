// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentIdentification8ValidatorTests
{
    private readonly PaymentIdentification8Validator _sut = new();

    private static PaymentIdentification8 ValidMessage() => new() { EndToEndIdentification = "E2E-001" };

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
            TransactionIdentification = "TX-001",
            UETR = "8a562590-5288-4dc0-a49d-9846f6720b17",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
