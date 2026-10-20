// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditorReferenceType3ValidatorTests
{
    private readonly CreditorReferenceType3Validator _sut = new();

    private static CreditorReferenceType3 ValidMessage() =>
        new()
        {
            CodeOrProprietary = new BeneficialStrategies.Iso20022.Choices.CreditorReferenceType2Choice.Proprietary
            {
                Value = "MYREFTYPE",
            },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = ValidMessage() with { Issuer = "IssuerCo" };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
