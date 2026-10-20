// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class DateAndDateTime2Choice_ValidatorTests
{
    private readonly DateAndDateTime2Choice_Validator _sut = new();

    [Fact]
    public void DateVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Samples.DateAndDateTime2Choice.Valid.Date.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void DateTimeVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Samples.DateAndDateTime2Choice.Valid.DateTime_.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
