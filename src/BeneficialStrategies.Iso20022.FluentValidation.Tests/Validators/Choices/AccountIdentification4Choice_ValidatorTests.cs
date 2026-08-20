// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class AccountIdentification4Choice_ValidatorTests
{
    private readonly AccountIdentification4Choice_Validator _sut = new();

    [Fact]
    public void IBANVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
            {
                Value = "DE89370400440532013000",
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OtherVariant_NoSchemeName_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.Other
            {
                Identification = "ACCT-001",
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OtherVariant_SchemeNamePresent_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.Other
            {
                Identification = "ACCT-001",
                SchemeName = new BeneficialStrategies.Iso20022.Choices.AccountSchemeName1Choice.Proprietary
                {
                    Value = "MYACCTSCHEME",
                },
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
