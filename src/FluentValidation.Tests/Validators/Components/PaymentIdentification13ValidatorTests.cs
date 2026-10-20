// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentIdentification13ValidatorTests
{
    private readonly PaymentIdentification13Validator _sut = new();

    private static PaymentIdentification13 ValidMessage() => new() { EndToEndIdentification = "E2E-001" };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFieldsPresent_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            InstructionIdentification = "INSTR-001",
            TransactionIdentification = "TX-001",
            UETR = "1fdb2f66-7d4c-4a5f-8fbb-123456789abc",
            ClearingSystemReference = "CLR-001",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
