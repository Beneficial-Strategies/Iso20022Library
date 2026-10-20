// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Contact13ValidatorTests
{
    private readonly Contact13Validator _sut = new();

    private static Contact13 ValidMessage() => new();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Other_NonEmpty_NoValidationError()
    {
        var msg = ValidMessage() with { Other = [new OtherContact1 { ChannelType = "FAXX" }] };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
