// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class RegulatoryAuthority2ValidatorTests
{
    private readonly RegulatoryAuthority2Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IRegulatoryAuthority2>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IRegulatoryAuthority2>(b => b
            .Set(x => x.Name).To("Financial Regulator")
            .Set(x => x.Country).To("US"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PopulatedRegistry_RejectsCountryNotInSet()
    {
        var registry = new InMemoryExternalCodeRegistry<CountryCode>();
        registry.Add("US");
        var sut = new RegulatoryAuthority2Validator(new CountryCodeValidator(registry));

        var result = sut.Validate(IsoDataFactory.Make<IRegulatoryAuthority2>(b => b
            .Set(x => x.Country).To("ZZ")));
        Assert.False(result.IsValid);
    }
}
