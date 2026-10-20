// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class DateAndDateTime2Choice_ValidatorTests
{
    private readonly DateAndDateTime2Choice_Validator _sut = new();

    [Fact]
    public void DateVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.Date
        {
            Value = new DateOnly(2026, 1, 1),
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void DateTimeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.DateTime
        {
            Value = new DateTime(2026, 1, 1),
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
