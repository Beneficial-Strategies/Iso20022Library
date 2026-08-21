// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class Amount2Choice_ValidatorTests
{
    private readonly Amount2Choice_Validator _sut = new();

    [Fact]
    public void AmountWithCurrencyVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.Amount2Choice.AmountWithCurrency
        {
            Currency = "USD",
            Amount = 100m,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AmountWithoutCurrencyVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.Amount2Choice.AmountWithoutCurrency
        {
            Currency = "USD",
            Amount = 100m,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
