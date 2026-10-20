// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class InstructionForDebtorAgent1ValidatorTests
{
    private readonly InstructionForDebtorAgent1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new InstructionForDebtorAgent1()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new InstructionForDebtorAgent1
        {
            Code = ExternalDebtorAgentInstruction1Code.PayCreditorByCheque,
            InstructionInformation = "Pay by cheque",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PopulatedRegistry_RejectsCodeNotInSet()
    {
        var registry = new InMemoryExternalCodeRegistry<ExternalDebtorAgentInstruction1Code>();
        registry.Add("CHQB");
        var sut = new InstructionForDebtorAgent1Validator(new ExternalDebtorAgentInstruction1CodeValidator(registry));

        var result = sut.Validate(new InstructionForDebtorAgent1 { Code = "ZZZZ" });
        Assert.False(result.IsValid);
    }
}
