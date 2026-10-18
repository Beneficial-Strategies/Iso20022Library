// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class ChequeDeliveryMethod1Choice_ValidatorTests
{
    private readonly ChequeDeliveryMethod1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = new Choices.ChequeDeliveryMethod1Choice.Code { Value = ChequeDelivery1Code.MailToDebtor };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new Choices.ChequeDeliveryMethod1Choice.Proprietary { Value = "COURIER" };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
