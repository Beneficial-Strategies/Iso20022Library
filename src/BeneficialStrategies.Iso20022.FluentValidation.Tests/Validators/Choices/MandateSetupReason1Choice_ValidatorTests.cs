// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class MandateSetupReason1Choice_ValidatorTests
{
    private readonly MandateSetupReason1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.MandateSetupReason1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.MandateSetupReason1Choice.Code
            {
                Value = new ExternalMandateSetupReason1Code("RIKA"),
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.MandateSetupReason1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.MandateSetupReason1Choice.Proprietary
            {
                Value = "MYREASON",
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
