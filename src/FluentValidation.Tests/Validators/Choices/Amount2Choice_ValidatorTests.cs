// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class Amount2Choice_ValidatorTests
{
    private readonly Amount2Choice_Validator _sut = new();

    [Fact]
    public void AmountWithCurrencyVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Samples.Amount2Choice.Valid.AmountWithCurrency.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AmountWithoutCurrencyVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Samples.Amount2Choice.Valid.AmountWithoutCurrency.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
