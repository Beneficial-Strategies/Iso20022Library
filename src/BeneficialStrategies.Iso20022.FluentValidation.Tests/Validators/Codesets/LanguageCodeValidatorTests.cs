// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.CodesetValidators;

public class LanguageCodeValidatorTests
{
    [Fact]
    public void DefaultRegistry_Permissive_AnyValueValid()
    {
        var sut = new LanguageCodeValidator();
        sut.TestValidate((LanguageCode)"EN").ShouldNotHaveAnyValidationErrors();
        sut.TestValidate((LanguageCode)"ZZZZZZ").ShouldNotHaveAnyValidationErrors(); // permissive
    }

    [Fact]
    public void PopulatedRegistry_RejectsValueNotInSet()
    {
        var registry = new InMemoryExternalCodeRegistry<LanguageCode>();
        registry.Add("EN");
        var sut = new LanguageCodeValidator(registry);

        sut.TestValidate((LanguageCode)"EN").ShouldNotHaveAnyValidationErrors();

        var result = sut.Validate((LanguageCode)"XX");
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "ExternalCodeRegistryRule");
    }
}
