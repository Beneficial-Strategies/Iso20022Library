// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class AccountSchemeName1Choice_ValidatorTests
{
    private readonly AccountSchemeName1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.AccountSchemeName1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.AccountSchemeName1Choice.Code { Value = ExternalAccountIdentification1Code.BBANIdentifier };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.AccountSchemeName1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.AccountSchemeName1Choice.Proprietary { Value = "MYACCTSCHEME" };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
