// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OrganisationIdentification39ValidatorTests
{
    private readonly OrganisationIdentification39Validator _sut = new();

    private static IOrganisationIdentification39 ValidMessage() => IsoDataFactory.Make<IOrganisationIdentification39>();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Other_NonEmpty_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Other).To([IsoDataFactory.Make<IGenericOrganisationIdentification3>(b2 => b2
                .Set(x2 => x2.Identification).To("ORG-001"))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
