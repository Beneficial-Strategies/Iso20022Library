// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class CreditorReferenceType2Choice_ValidatorTests
{
    private readonly CreditorReferenceType2Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.CreditorReferenceType2Choice.Code
        {
            Value = ExternalCreditorReferenceType1Code.DispatchAdvice,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.CreditorReferenceType2Choice.Proprietary
        {
            Value = "MYREFTYPE",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
