// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class DatePeriod2Choice_ValidatorTests
{
    private readonly DatePeriod2Choice_Validator _sut = new();

    [Fact]
    public void FromDateVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Messages.Samples.DatePeriod2Choice.Valid.FromDate.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void FromToDateVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Messages.Samples.DatePeriod2Choice.Valid.FromToDate.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
