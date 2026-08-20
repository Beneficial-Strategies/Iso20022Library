// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class MandateStatus1Choice_ValidatorTests
{
    private readonly MandateStatus1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.MandateStatus1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.MandateStatus1Choice.Code
            {
                Value = ExternalMandateStatus1Code.Active,
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.MandateStatus1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.MandateStatus1Choice.Proprietary
            {
                Value = "CUSTOMSTATUS",
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
