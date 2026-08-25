// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalGroupInformation33ValidatorTests
{
    private readonly OriginalGroupInformation33Validator _sut = new();

    private static OriginalGroupInformation33 ValidMessage() =>
        new() { OriginalMessageIdentification = "MSG-001", OriginalMessageNameIdentification = "pacs.008.001.08" };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalCreationDateTime_Present_NoValidationError()
    {
        var msg = ValidMessage() with { OriginalCreationDateTime = new DateTime(2026, 1, 1) };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
