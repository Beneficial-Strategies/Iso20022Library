// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class OrganisationIdentificationSchemeName1Choice_ValidatorTests
{
    private readonly OrganisationIdentificationSchemeName1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.OrganisationIdentificationSchemeName1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.OrganisationIdentificationSchemeName1Choice.Code
            {
                Value = ExternalOrganisationIdentification1Code.BankPartyIdentification,
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.OrganisationIdentificationSchemeName1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.OrganisationIdentificationSchemeName1Choice.Proprietary
            {
                Value = "MYSCHEME",
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
