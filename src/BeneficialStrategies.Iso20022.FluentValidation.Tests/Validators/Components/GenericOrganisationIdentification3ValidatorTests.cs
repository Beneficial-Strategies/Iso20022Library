// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GenericOrganisationIdentification3ValidatorTests
{
    private readonly GenericOrganisationIdentification3Validator _sut = new();

    private static GenericOrganisationIdentification3 ValidMessage() =>
        new() { Identification = "ORG-001" };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SchemeName_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SchemeName =
                new BeneficialStrategies.Iso20022.Choices.OrganisationIdentificationSchemeName1Choice.Proprietary
                {
                    Value = "MYSCHEME",
                },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
