// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalBusinessQuery1ValidatorTests
{
    private readonly OriginalBusinessQuery1Validator _sut = new();

    private static OriginalBusinessQuery1 ValidMessage() => new() { MessageIdentification = "ORIG-MSG-001" };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            MessageNameIdentification = "camt.003.001.08",
            CreationDateTime = new DateTime(2026, 1, 1),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
