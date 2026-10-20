// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class ClearingSystemIdentification2Choice_ValidatorTests
{
    private readonly ClearingSystemIdentification2Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification2Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification2Choice.Code
            {
                Value = ExternalClearingSystemIdentification1Code.AustrianBankleitzahl,
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification2Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification2Choice.Proprietary
            {
                Value = "MYCLRSYS",
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
