// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class PersonIdentificationSchemeName1Choice_ValidatorTests
{
    private readonly PersonIdentificationSchemeName1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IPersonIdentificationSchemeName1Choice choice =
            IsoDataFactory.Make<Choices.PersonIdentificationSchemeName1Choice.ICode>(b => b
                .Set(x => x.Value).To(ExternalPersonIdentification1Code.PassportNumber));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IPersonIdentificationSchemeName1Choice choice =
            IsoDataFactory.Make<Choices.PersonIdentificationSchemeName1Choice.IProprietary>(b => b
                .Set(x => x.Value).To("MYSCHEME"));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
