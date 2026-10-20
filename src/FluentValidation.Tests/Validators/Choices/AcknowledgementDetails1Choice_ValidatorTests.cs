// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class AcknowledgementDetails1Choice_ValidatorTests
{
    private readonly AcknowledgementDetails1Choice_Validator _sut = new();

    [Fact]
    public void PayInScheduleReferenceVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.AcknowledgementDetails1Choice.PayInScheduleReference
        {
            Value = "PIS-001",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PayInCallReferenceVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.AcknowledgementDetails1Choice.PayInCallReference
        {
            Value = "PIC-001",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
