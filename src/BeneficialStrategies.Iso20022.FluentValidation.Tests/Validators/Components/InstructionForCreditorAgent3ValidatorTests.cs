// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class InstructionForCreditorAgent3ValidatorTests
{
    private readonly InstructionForCreditorAgent3Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new InstructionForCreditorAgent3()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new InstructionForCreditorAgent3
        {
            Code = ExternalCreditorAgentInstruction1Code.PayCreditorByCheque,
            InstructionInformation = "Pay by cheque",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
