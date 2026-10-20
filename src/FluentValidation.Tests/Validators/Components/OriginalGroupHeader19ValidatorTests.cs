// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalGroupHeader19ValidatorTests
{
    private readonly OriginalGroupHeader19Validator _sut = new();

    private static OriginalGroupHeader19 ValidMessage() =>
        new() { OriginalMessageIdentification = "ORGMSG-001", OriginalMessageNameIdentification = "pacs.008.001.14" };

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

    [Fact]
    public void ReturnReasonInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with { ReturnReasonInformation = [new PaymentReturnReason7 { Originator = new PartyIdentification272() }] };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
