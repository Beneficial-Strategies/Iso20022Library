// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalGroupHeader20ValidatorTests
{
    private readonly OriginalGroupHeader20Validator _sut = new();

    private static OriginalGroupHeader20 ValidMessage() =>
        new() { OriginalMessageIdentification = "MSG-001", OriginalMessageNameIdentification = "pain.007.001.13" };

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
            OriginalCreationDateTime = new DateTime(2026, 1, 1),
            ReversalReasonInformation = [new PaymentReversalReason10()],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
