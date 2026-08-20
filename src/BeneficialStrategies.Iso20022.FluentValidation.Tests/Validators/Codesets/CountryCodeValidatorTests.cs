// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.CodesetValidators;

public class CountryCodeValidatorTests
{
    [Fact]
    public void DefaultRegistry_Permissive_AnyValueValid()
    {
        var sut = new CountryCodeValidator();
        sut.TestValidate((CountryCode)"US").ShouldNotHaveAnyValidationErrors();
        sut.TestValidate((CountryCode)"ZZ").ShouldNotHaveAnyValidationErrors(); // permissive
    }

    [Fact]
    public void PopulatedRegistry_RejectsValueNotInSet()
    {
        var registry = new InMemoryExternalCodeRegistry<CountryCode>();
        registry.Add("US");
        var sut = new CountryCodeValidator(registry);

        sut.TestValidate((CountryCode)"US").ShouldNotHaveAnyValidationErrors();

        var result = sut.Validate((CountryCode)"ZZ");
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "ExternalCodeRegistryRule");
    }
}
