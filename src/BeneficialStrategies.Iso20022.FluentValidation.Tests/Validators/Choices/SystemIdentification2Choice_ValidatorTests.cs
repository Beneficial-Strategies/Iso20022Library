// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class SystemIdentification2Choice_ValidatorTests
{
    private readonly SystemIdentification2Choice_Validator _sut = new();

    [Fact]
    public void CountryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.SystemIdentification2Choice.Country { Value = "DE" };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void MarketInfrastructureIdentificationVariant_NoValidationErrors()
    {
        var value =
            new BeneficialStrategies.Iso20022.Choices.SystemIdentification2Choice.MarketInfrastructureIdentification();
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
