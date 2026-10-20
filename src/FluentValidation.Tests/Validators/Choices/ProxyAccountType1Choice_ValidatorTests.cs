// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class ProxyAccountType1Choice_ValidatorTests
{
    private readonly ProxyAccountType1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.ProxyAccountType1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.ProxyAccountType1Choice.Code { Value = ExternalProxyAccountType1Code.TelephoneNumber };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.ProxyAccountType1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.ProxyAccountType1Choice.Proprietary { Value = "MYPROXYTYPE" };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
