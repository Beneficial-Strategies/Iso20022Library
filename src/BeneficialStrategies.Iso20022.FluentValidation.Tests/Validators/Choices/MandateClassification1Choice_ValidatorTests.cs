// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class MandateClassification1Choice_ValidatorTests
{
    private readonly MandateClassification1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.MandateClassification1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.MandateClassification1Choice.Code { Value = MandateClassification1Code.Fixed };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.MandateClassification1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.MandateClassification1Choice.Proprietary { Value = "MYCLASS" };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
