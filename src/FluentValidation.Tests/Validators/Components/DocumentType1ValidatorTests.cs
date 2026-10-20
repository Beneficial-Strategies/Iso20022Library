// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DocumentType1ValidatorTests
{
    private readonly DocumentType1Validator _sut = new();

    private static DocumentType1 ValidMessage() =>
        new()
        {
            CodeOrProprietary = new BeneficialStrategies.Iso20022.Choices.DocumentType2Choice.Proprietary
            {
                Value = "MYDOCTYPE",
            },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
