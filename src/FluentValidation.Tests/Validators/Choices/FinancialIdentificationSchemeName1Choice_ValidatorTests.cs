// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class FinancialIdentificationSchemeName1Choice_ValidatorTests
{
    private readonly FinancialIdentificationSchemeName1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IFinancialIdentificationSchemeName1Choice choice =
            IsoDataFactory.Make<Choices.FinancialIdentificationSchemeName1Choice.ICode>(b => b
                .Set(x => x.Value).To(new ExternalFinancialInstitutionIdentification1Code("BANK")));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IFinancialIdentificationSchemeName1Choice choice =
            IsoDataFactory.Make<Choices.FinancialIdentificationSchemeName1Choice.IProprietary>(b => b
                .Set(x => x.Value).To("MYSCHEME"));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
