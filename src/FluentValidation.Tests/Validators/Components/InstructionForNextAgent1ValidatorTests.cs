// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class InstructionForNextAgent1ValidatorTests
{
    private readonly InstructionForNextAgent1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new InstructionForNextAgent1()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllFieldsPresent_NoValidationErrors()
    {
        var msg = new InstructionForNextAgent1
        {
            Code = Instruction4Code.PhoneNextAgent,
            InstructionInformation = "Call before delivery",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
