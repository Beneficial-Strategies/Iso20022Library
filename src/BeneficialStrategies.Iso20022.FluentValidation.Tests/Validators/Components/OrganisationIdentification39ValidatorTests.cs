// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OrganisationIdentification39ValidatorTests
{
    private readonly OrganisationIdentification39Validator _sut = new();

    private static OrganisationIdentification39 ValidMessage() => new();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Other_NonEmpty_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            Other = [new GenericOrganisationIdentification3 { Identification = "ORG-001" }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
