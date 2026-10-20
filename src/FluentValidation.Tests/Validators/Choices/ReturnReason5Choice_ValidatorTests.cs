// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class ReturnReason5Choice_ValidatorTests
{
    private readonly ReturnReason5Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.ReturnReason5Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.ReturnReason5Choice.Code
            {
                Value = ExternalReturnReason1Code.IncorrectAccountNumber,
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.ReturnReason5Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.ReturnReason5Choice.Proprietary { Value = "CUSTOM-REASON" };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
