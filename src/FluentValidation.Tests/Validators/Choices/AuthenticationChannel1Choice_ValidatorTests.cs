// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class AuthenticationChannel1Choice_ValidatorTests
{
    private readonly AuthenticationChannel1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.AuthenticationChannel1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.AuthenticationChannel1Choice.Code { Value = ExternalAuthenticationChannel1Code.ATM };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.AuthenticationChannel1Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.AuthenticationChannel1Choice.Proprietary { Value = "CHANNELX" };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
