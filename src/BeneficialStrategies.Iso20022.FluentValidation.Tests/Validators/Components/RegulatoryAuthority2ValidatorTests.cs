// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class RegulatoryAuthority2ValidatorTests
{
    private readonly RegulatoryAuthority2Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new RegulatoryAuthority2()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new RegulatoryAuthority2 { Name = "Financial Regulator", Country = "US" };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PopulatedRegistry_RejectsCountryNotInSet()
    {
        var registry = new InMemoryExternalCodeRegistry<CountryCode>();
        registry.Add("US");
        var sut = new RegulatoryAuthority2Validator(new CountryCodeValidator(registry));

        var result = sut.Validate(new RegulatoryAuthority2 { Country = "ZZ" });
        Assert.False(result.IsValid);
    }
}
