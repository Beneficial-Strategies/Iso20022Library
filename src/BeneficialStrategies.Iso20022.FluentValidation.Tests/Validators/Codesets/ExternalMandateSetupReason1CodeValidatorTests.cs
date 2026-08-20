// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.CodesetValidators;

public class ExternalMandateSetupReason1CodeValidatorTests
{
    [Fact]
    public void DefaultRegistry_Permissive_AnyValueValid()
    {
        var sut = new ExternalMandateSetupReason1CodeValidator();
        sut.TestValidate(new ExternalMandateSetupReason1Code("RIKA")).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PopulatedRegistry_RejectsValueNotInSet()
    {
        var registry = new InMemoryExternalCodeRegistry<ExternalMandateSetupReason1Code>();
        registry.Add("RIKA");
        var sut = new ExternalMandateSetupReason1CodeValidator(registry);

        sut.TestValidate(new ExternalMandateSetupReason1Code("RIKA")).ShouldNotHaveAnyValidationErrors();

        var result = sut.Validate(new ExternalMandateSetupReason1Code("ZZZZ"));
        Assert.False(result.IsValid);
    }
}
