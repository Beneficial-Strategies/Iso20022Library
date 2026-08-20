// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.CodesetValidators;

public class ActiveOrHistoricCurrencyCodeValidatorTests
{
    [Fact]
    public void DefaultRegistry_Permissive_AnyValueValid()
    {
        var sut = new ActiveOrHistoricCurrencyCodeValidator();
        sut.TestValidate((ActiveOrHistoricCurrencyCode)"USD").ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PopulatedRegistry_RejectsValueNotInSet()
    {
        var registry = new InMemoryExternalCodeRegistry<ActiveOrHistoricCurrencyCode>();
        registry.Add("USD");
        var sut = new ActiveOrHistoricCurrencyCodeValidator(registry);

        sut.TestValidate((ActiveOrHistoricCurrencyCode)"USD").ShouldNotHaveAnyValidationErrors();

        var result = sut.Validate((ActiveOrHistoricCurrencyCode)"ZZZ");
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "ExternalCodeRegistryRule");
    }
}
