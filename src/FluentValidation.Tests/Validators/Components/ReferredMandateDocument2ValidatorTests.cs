// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ReferredMandateDocument2ValidatorTests
{
    private readonly ReferredMandateDocument2Validator _sut = new();

    private static IReferredMandateDocument2 ValidMessage() => IsoDataFactory.Make<IReferredMandateDocument2>();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.RelatedDate).To(IsoDataFactory.Make<IDateAndType1>(b2 => b2
                .Set(x2 => x2.Date).To(new DateOnly(2026, 1, 1))
                .Set(x2 => x2.Type).To(IsoDataFactory.Make<Choices.DateType2Choice.IProprietary>(b3 => b3
                    .Set(x3 => x3.Value).To("MYDATETYPE")))))
            .Set(x => x.Type).To(IsoDataFactory.Make<IDocumentType1>(b2 => b2
                .Set(x2 => x2.CodeOrProprietary).To(IsoDataFactory.Make<Choices.DocumentType2Choice.IProprietary>(b3 => b3
                    .Set(x3 => x3.Value).To("MYDOCTYPE"))))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
