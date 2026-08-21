// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class ExecutionType1Choice_ValidatorTests
{
    private readonly ExecutionType1Choice_Validator _sut = new();

    [Fact]
    public void TimeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.ExecutionType1Choice.Time
        {
            Value = new TimeOnly(9, 0, 0),
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EventVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.ExecutionType1Choice.Event();
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
