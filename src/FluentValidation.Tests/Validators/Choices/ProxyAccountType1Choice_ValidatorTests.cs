// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class ProxyAccountType1Choice_ValidatorTests
{
    private readonly ProxyAccountType1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IProxyAccountType1Choice choice =
            IsoDataFactory.Make<Choices.ProxyAccountType1Choice.ICode>(b => b
                .Set(x => x.Value).To(ExternalProxyAccountType1Code.TelephoneNumber));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IProxyAccountType1Choice choice =
            IsoDataFactory.Make<Choices.ProxyAccountType1Choice.IProprietary>(b => b
                .Set(x => x.Value).To("MYPROXYTYPE"));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
