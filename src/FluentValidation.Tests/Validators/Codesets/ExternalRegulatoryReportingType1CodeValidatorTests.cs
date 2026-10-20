// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.CodesetValidators;

public class ExternalRegulatoryReportingType1CodeValidatorTests
{
    [Fact]
    public void DefaultRegistry_Permissive_AnyValueValid()
    {
        var sut = new ExternalRegulatoryReportingType1CodeValidator();
        sut.TestValidate((ExternalRegulatoryReportingType1Code)"CRED").ShouldNotHaveAnyValidationErrors();
        sut.TestValidate((ExternalRegulatoryReportingType1Code)"ZZZZ").ShouldNotHaveAnyValidationErrors(); // permissive
    }

    [Fact]
    public void PopulatedRegistry_RejectsValueNotInSet()
    {
        var registry = new InMemoryExternalCodeRegistry<ExternalRegulatoryReportingType1Code>();
        registry.Add("CRED");
        var sut = new ExternalRegulatoryReportingType1CodeValidator(registry);

        sut.TestValidate((ExternalRegulatoryReportingType1Code)"CRED").ShouldNotHaveAnyValidationErrors();

        var result = sut.Validate((ExternalRegulatoryReportingType1Code)"DEBT");
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "ExternalCodeRegistryRule");
    }
}
