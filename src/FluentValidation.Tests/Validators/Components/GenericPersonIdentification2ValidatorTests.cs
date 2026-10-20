// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GenericPersonIdentification2ValidatorTests
{
    private readonly GenericPersonIdentification2Validator _sut = new();

    private static GenericPersonIdentification2 ValidMessage() =>
        new() { Identification = "PERS-001" };

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
                new BeneficialStrategies.Iso20022.Choices.PersonIdentificationSchemeName1Choice.Proprietary
                {
                    Value = "MYSCHEME",
                },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
