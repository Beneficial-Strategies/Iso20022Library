// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class AddressType3Choice_ValidatorTests
{
    private readonly AddressType3Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.AddressType3Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.AddressType3Choice.Code
            {
                Value = AddressType2Code.Business,
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.AddressType3Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.AddressType3Choice.Proprietary
            {
                Identification = "AB12",
                Issuer = "IssuerX",
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
