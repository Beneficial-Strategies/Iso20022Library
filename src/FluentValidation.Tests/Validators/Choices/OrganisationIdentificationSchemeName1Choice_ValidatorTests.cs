// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class OrganisationIdentificationSchemeName1Choice_ValidatorTests
{
    private readonly OrganisationIdentificationSchemeName1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IOrganisationIdentificationSchemeName1Choice choice =
            IsoDataFactory.Make<Choices.OrganisationIdentificationSchemeName1Choice.ICode>(b => b
                .Set(x => x.Value).To(ExternalOrganisationIdentification1Code.BankPartyIdentification));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IOrganisationIdentificationSchemeName1Choice choice =
            IsoDataFactory.Make<Choices.OrganisationIdentificationSchemeName1Choice.IProprietary>(b => b
                .Set(x => x.Value).To("MYSCHEME"));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
