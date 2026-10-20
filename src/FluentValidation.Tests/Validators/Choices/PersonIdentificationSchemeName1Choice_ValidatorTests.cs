// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class PersonIdentificationSchemeName1Choice_ValidatorTests
{
    private readonly PersonIdentificationSchemeName1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.PersonIdentificationSchemeName1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.PersonIdentificationSchemeName1Choice.Code
            {
                Value = ExternalPersonIdentification1Code.PassportNumber,
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.PersonIdentificationSchemeName1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.PersonIdentificationSchemeName1Choice.Proprietary
            {
                Value = "MYSCHEME",
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
