// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class SystemIdentification2Choice_ValidatorTests
{
    private readonly SystemIdentification2Choice_Validator _sut = new();

    [Fact]
    public void CountryVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.SystemIdentification2Choice.ICountry>(b => b
            .Set(x => x.Value).To("DE"));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void MarketInfrastructureIdentificationVariant_NoValidationErrors()
    {
        var value =
            IsoDataFactory.Make<Choices.SystemIdentification2Choice.IMarketInfrastructureIdentification>(b => b
                .Set(x => x.Value).To(IsoDataFactory.Make<Choices.MarketInfrastructureIdentification1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MI"))));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
