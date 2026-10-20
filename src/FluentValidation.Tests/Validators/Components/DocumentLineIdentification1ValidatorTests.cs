// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DocumentLineIdentification1ValidatorTests
{
    private readonly DocumentLineIdentification1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IDocumentLineIdentification1>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IDocumentLineIdentification1>(b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<IDocumentLineType1>(b2 => b2
                .Set(x2 => x2.CodeOrProprietary).To(IsoDataFactory.Make<Choices.DocumentLineType1Choice.IProprietary>(b3 => b3
                    .Set(x3 => x3.Value).To("MYLINETYPE")))))
            .Set(x => x.Number).To("LINE-001")
            .Set(x => x.RelatedDate).To(new DateOnly(2026, 1, 1)));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
