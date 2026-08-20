// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.CodesetValidators;

public class ExternalFinancialInstitutionIdentification1CodeValidatorTests
{
    [Fact]
    public void DefaultRegistry_Permissive_AnyValueValid()
    {
        var sut = new ExternalFinancialInstitutionIdentification1CodeValidator();
        sut.TestValidate(new ExternalFinancialInstitutionIdentification1Code("BANK"))
            .ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PopulatedRegistry_RejectsValueNotInSet()
    {
        var registry = new InMemoryExternalCodeRegistry<ExternalFinancialInstitutionIdentification1Code>();
        registry.Add("BANK");
        var sut = new ExternalFinancialInstitutionIdentification1CodeValidator(registry);

        sut.TestValidate(new ExternalFinancialInstitutionIdentification1Code("BANK"))
            .ShouldNotHaveAnyValidationErrors();

        var result = sut.Validate(new ExternalFinancialInstitutionIdentification1Code("ZZZZ"));
        Assert.False(result.IsValid);
    }
}
