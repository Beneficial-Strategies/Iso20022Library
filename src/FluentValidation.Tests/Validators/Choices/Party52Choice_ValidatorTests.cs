// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class Party52Choice_ValidatorTests
{
    private readonly Party52Choice_Validator _sut = new();

    [Fact]
    public void OrganisationIdentificationVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IParty52Choice choice =
            IsoDataFactory.Make<Choices.Party52Choice.IOrganisationIdentification>(b => b
                .Set(x => x.Value).To(IsoDataFactory.Make<IOrganisationIdentification39>()));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PrivateIdentificationVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IParty52Choice choice =
            IsoDataFactory.Make<Choices.Party52Choice.IPrivateIdentification>(b => b
                .Set(x => x.Value).To(IsoDataFactory.Make<IPersonIdentification18>()));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
