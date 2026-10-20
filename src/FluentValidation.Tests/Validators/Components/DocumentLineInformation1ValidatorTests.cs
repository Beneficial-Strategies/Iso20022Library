// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DocumentLineInformation1ValidatorTests
{
    private readonly DocumentLineInformation1Validator _sut = new();

    private static DocumentLineInformation1 ValidMessage() =>
        new() { Identification = [new DocumentLineIdentification1()] };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Identification: DocumentLineIdentification1, 1..∞ ─────────────────────

    [Fact]
    public void Identification_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { Identification = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Identification);
    }

    [Fact]
    public void Identification_OneElement_NoValidationError()
    {
        var msg = ValidMessage() with { Identification = [new DocumentLineIdentification1()] };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.Identification);
    }
}
