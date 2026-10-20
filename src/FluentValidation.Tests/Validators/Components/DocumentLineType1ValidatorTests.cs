// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DocumentLineType1ValidatorTests
{
    private readonly DocumentLineType1Validator _sut = new();

    private static DocumentLineType1 ValidMessage() =>
        new()
        {
            CodeOrProprietary = new BeneficialStrategies.Iso20022.Choices.DocumentLineType1Choice.Proprietary
            {
                Value = "MYLINETYPE",
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
