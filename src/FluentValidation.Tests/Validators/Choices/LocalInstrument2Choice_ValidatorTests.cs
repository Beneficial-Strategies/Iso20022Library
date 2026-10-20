// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class LocalInstrument2Choice_ValidatorTests
{
    private readonly LocalInstrument2Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.LocalInstrument2Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.LocalInstrument2Choice.Code { Value = ExternalLocalInstrument1Code.BatchPaymentsAruba };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.LocalInstrument2Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.LocalInstrument2Choice.Proprietary { Value = "MYINSTR" };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
