// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DocumentLineInformation2ValidatorTests
{
    private readonly DocumentLineInformation2Validator _sut = new();

    private static IDocumentLineInformation2 ValidMessage() =>
        IsoDataFactory.Make<IDocumentLineInformation2>(b => b
            .Set(x => x.Identification).To([IsoDataFactory.Make<IDocumentLineIdentification1>()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Identification: DocumentLineIdentification1, 1..∞ ─────────────────────

    [Fact]
    public void Identification_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Identification).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Identification);
    }

    [Fact]
    public void Identification_OneElement_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Identification).To([IsoDataFactory.Make<IDocumentLineIdentification1>()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.Identification);
    }
}
