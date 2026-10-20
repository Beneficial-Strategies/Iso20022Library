// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalMessageInformation1ValidatorTests
{
    private readonly OriginalMessageInformation1Validator _sut = new();

    private static OriginalMessageInformation1 ValidMessage() =>
        new() { MessageIdentification = "MSG-001", MessageNameIdentification = "pain.017.001.04" };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CreationDateTime_Present_NoValidationError()
    {
        var msg = ValidMessage() with { CreationDateTime = new DateTime(2026, 1, 1) };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
