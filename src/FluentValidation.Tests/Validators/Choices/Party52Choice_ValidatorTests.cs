// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class Party52Choice_ValidatorTests
{
    private readonly Party52Choice_Validator _sut = new();

    [Fact]
    public void OrganisationIdentificationVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.Party52Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.Party52Choice.OrganisationIdentification
            {
                Value = new OrganisationIdentification39(),
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PrivateIdentificationVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.Party52Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.Party52Choice.PrivateIdentification
            {
                Value = new PersonIdentification18(),
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
