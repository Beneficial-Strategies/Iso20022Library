// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class CashAccountType2Choice_ValidatorTests
{
    private readonly CashAccountType2Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.CashAccountType2Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.CashAccountType2Choice.Code { Value = ExternalCashAccountType1Code.Current };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.CashAccountType2Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.CashAccountType2Choice.Proprietary { Value = "MYTYPE" };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
