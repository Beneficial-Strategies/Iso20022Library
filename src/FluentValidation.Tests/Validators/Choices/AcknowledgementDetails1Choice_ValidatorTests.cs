// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class AcknowledgementDetails1Choice_ValidatorTests
{
    private readonly AcknowledgementDetails1Choice_Validator _sut = new();

    [Fact]
    public void PayInScheduleReferenceVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Samples.AcknowledgementDetails1Choice.Valid.PayInScheduleReference.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PayInCallReferenceVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Samples.AcknowledgementDetails1Choice.Valid.PayInCallReference.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
