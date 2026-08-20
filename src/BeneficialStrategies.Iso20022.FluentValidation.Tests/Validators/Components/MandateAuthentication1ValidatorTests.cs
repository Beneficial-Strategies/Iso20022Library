// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateAuthentication1ValidatorTests
{
    private readonly MandateAuthentication1Validator _sut = new();

    private static MandateAuthentication1 ValidMessage() => new();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Channel_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            Channel = new BeneficialStrategies.Iso20022.Choices.AuthenticationChannel1Choice.Proprietary
            {
                Value = "CHANNELX",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
