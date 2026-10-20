// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class AccountIdentification4Choice_ValidatorTests
{
    private readonly AccountIdentification4Choice_Validator _sut = new();

    [Fact]
    public void IBANVariant_NoValidationErrors()
    {
        var choice = BeneficialStrategies.Iso20022.Samples.AccountIdentification4Choice.Valid.IBAN.Minimal;
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OtherVariant_NoSchemeName_NoValidationErrors()
    {
        var choice = BeneficialStrategies.Iso20022.Samples.AccountIdentification4Choice.Valid.Other.Minimal;
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OtherVariant_SchemeNamePresent_NoValidationErrors()
    {
        var choice = BeneficialStrategies.Iso20022.Samples.AccountIdentification4Choice.Valid.Other.Maximal;
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
