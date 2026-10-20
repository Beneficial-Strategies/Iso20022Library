// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class Authorisation1Choice_ValidatorTests
{
    private readonly Authorisation1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.Authorisation1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.Authorisation1Choice.Code
            {
                Value = Authorisation1Code.PreAuthorisedFile,
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.Authorisation1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.Authorisation1Choice.Proprietary
            {
                Value = "LEVEL2",
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
