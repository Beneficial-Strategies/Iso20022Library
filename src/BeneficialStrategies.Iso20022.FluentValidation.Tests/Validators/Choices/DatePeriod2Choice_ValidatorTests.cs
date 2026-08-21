// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class DatePeriod2Choice_ValidatorTests
{
    private readonly DatePeriod2Choice_Validator _sut = new();

    [Fact]
    public void FromDateVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.DatePeriod2Choice.FromDate
        {
            Value = new DateOnly(2026, 1, 1),
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void FromToDateVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.DatePeriod2Choice.FromToDate
        {
            FromDate = new DateOnly(2026, 1, 1),
            ToDate = new DateOnly(2026, 12, 31),
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
