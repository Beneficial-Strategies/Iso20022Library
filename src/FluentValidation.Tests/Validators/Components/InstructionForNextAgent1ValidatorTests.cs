// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class InstructionForNextAgent1ValidatorTests
{
    private readonly InstructionForNextAgent1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IInstructionForNextAgent1>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllFieldsPresent_NoValidationErrors()
    {
        var msg = IsoDataFactory.Make<IInstructionForNextAgent1>(b => b
            .Set(x => x.Code).To(Instruction4Code.PhoneNextAgent)
            .Set(x => x.InstructionInformation).To("Call before delivery"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
