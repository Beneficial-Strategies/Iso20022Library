// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class AmountOrRate1Choice_ValidatorTests
{
    private readonly AmountOrRate1Choice_Validator _sut = new();

    [Fact]
    public void AmountVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.AmountOrRate1Choice.Amount
        {
            Currency = "USD",
            Value = 100m,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void RateVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.AmountOrRate1Choice.Rate { Value = 5.5m };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
