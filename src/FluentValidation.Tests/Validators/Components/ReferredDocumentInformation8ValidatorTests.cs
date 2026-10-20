// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ReferredDocumentInformation8ValidatorTests
{
    private readonly ReferredDocumentInformation8Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IReferredDocumentInformation8>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IReferredDocumentInformation8>(b => b
            .Set(x => x.LineDetails).To([IsoDataFactory.Make<IDocumentLineInformation2>(b2 => b2
                .Set(x2 => x2.Identification).To([IsoDataFactory.Make<IDocumentLineIdentification1>()]))])
            .Set(x => x.Number).To("DOC-001")
            .Set(x => x.RelatedDate).To(IsoDataFactory.Make<IDateAndType1>(b2 => b2
                .Set(x2 => x2.Date).To(new DateOnly(2026, 1, 1))
                .Set(x2 => x2.Type).To(IsoDataFactory.Make<Choices.DateType2Choice.IProprietary>(b3 => b3
                    .Set(x3 => x3.Value).To("MYDATE")))))
            .Set(x => x.Type).To(IsoDataFactory.Make<IDocumentType1>(b2 => b2
                .Set(x2 => x2.CodeOrProprietary).To(IsoDataFactory.Make<Choices.DocumentType2Choice.IProprietary>(b3 => b3
                    .Set(x3 => x3.Value).To("MYDOCTYPE"))))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
