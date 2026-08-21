// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.CodesetValidators;

public class ExternalDebtorAgentInstruction1CodeValidatorTests
{
    [Fact]
    public void DefaultRegistry_AutoSeededFromKnownMembers_AcceptsKnownValue()
    {
        var sut = new ExternalDebtorAgentInstruction1CodeValidator();
        sut.TestValidate(ExternalDebtorAgentInstruction1Code.PayCreditorByCheque).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void DefaultRegistry_AutoSeededFromKnownMembers_RejectsValueNotInSet()
    {
        var sut = new ExternalDebtorAgentInstruction1CodeValidator();
        var result = sut.Validate((ExternalDebtorAgentInstruction1Code)"ZZZZ");
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "ExternalCodeRegistryRule");
    }
}
