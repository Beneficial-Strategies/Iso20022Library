// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.CodesetValidators;

public class ActiveCurrencyCodeValidatorTests
{
    [Fact]
    public void DefaultRegistry_Permissive_AnyValueValid()
    {
        var sut = new ActiveCurrencyCodeValidator();
        sut.TestValidate((ActiveCurrencyCode)"USD").ShouldNotHaveAnyValidationErrors();
        sut.TestValidate((ActiveCurrencyCode)"ZZZ").ShouldNotHaveAnyValidationErrors(); // permissive
    }

    [Fact]
    public void PopulatedRegistry_RejectsValueNotInSet()
    {
        var registry = new InMemoryExternalCodeRegistry<ActiveCurrencyCode>();
        registry.Add("USD");
        var sut = new ActiveCurrencyCodeValidator(registry);

        sut.TestValidate((ActiveCurrencyCode)"USD").ShouldNotHaveAnyValidationErrors();

        var result = sut.Validate((ActiveCurrencyCode)"ZZZ");
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "ExternalCodeRegistryRule");
    }
}
