// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class ExecutionType1Choice_ValidatorTests
{
    private readonly ExecutionType1Choice_Validator _sut = new();

    [Fact]
    public void TimeVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.ExecutionType1Choice.ITime>(b => b
            .Set(x => x.Value).To(new TimeOnly(9, 0, 0)));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void EventVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.ExecutionType1Choice.IEvent>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<Choices.EventType1Choice.IProprietary>(b2 => b2
            .Set(x2 => x2.Value).To("EVT"))));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
