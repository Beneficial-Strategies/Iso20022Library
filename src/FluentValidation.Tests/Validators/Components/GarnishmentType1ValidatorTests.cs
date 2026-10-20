// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GarnishmentType1ValidatorTests
{
    private readonly GarnishmentType1Validator _sut = new();

    private static GarnishmentType1 ValidMessage() =>
        new()
        {
            CodeOrProprietary = new BeneficialStrategies.Iso20022.Choices.GarnishmentType1Choice.Proprietary
            {
                Value = "MYGARNISHMENT",
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
