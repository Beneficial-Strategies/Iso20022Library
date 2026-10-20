// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class Purpose2Choice_ValidatorTests
{
    private readonly Purpose2Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.Purpose2Choice.Code
        {
            Value = ExternalPurpose1Code.BankLoanDelayedDrawFunding,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.Purpose2Choice.Proprietary { Value = "MYPURPOSE" };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
