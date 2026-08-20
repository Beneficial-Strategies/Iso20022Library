// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OtherContact1ValidatorTests
{
    private readonly OtherContact1Validator _sut = new();

    private static OtherContact1 ValidMessage() => new() { ChannelType = "FAXX" };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Identification_Present_NoValidationError()
    {
        var msg = ValidMessage() with { Identification = "+1-555-0100" };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
