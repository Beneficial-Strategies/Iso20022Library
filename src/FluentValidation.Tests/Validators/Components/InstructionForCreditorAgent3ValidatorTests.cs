// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class InstructionForCreditorAgent3ValidatorTests
{
    private readonly InstructionForCreditorAgent3Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IInstructionForCreditorAgent3>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IInstructionForCreditorAgent3>(b => b
            .Set(x => x.Code).To(ExternalCreditorAgentInstruction1Code.PayCreditorByCheque)
            .Set(x => x.InstructionInformation).To("Pay by cheque"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
