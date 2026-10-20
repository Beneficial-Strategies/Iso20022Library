// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class MandateRelatedData5Choice_ValidatorTests
{
    private readonly MandateRelatedData5Choice_Validator _sut = new();

    [Fact]
    public void DirectDebitMandateVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.MandateRelatedData5Choice.DirectDebitMandate
        {
            Value = new MandateRelatedInformation16(),
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CreditTransferMandateVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.MandateRelatedData5Choice.CreditTransferMandate
        {
            Value = new CreditTransferMandateData1(),
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
