// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ReferredDocumentInformation8ValidatorTests
{
    private readonly ReferredDocumentInformation8Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new ReferredDocumentInformation8()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new ReferredDocumentInformation8
        {
            LineDetails = [new DocumentLineInformation2 { Identification = [new DocumentLineIdentification1()] }],
            Number = "DOC-001",
            RelatedDate = new DateAndType1
            {
                Date = new DateOnly(2026, 1, 1),
                Type = new BeneficialStrategies.Iso20022.Choices.DateType2Choice.Proprietary { Value = "MYDATE" },
            },
            Type = new DocumentType1
            {
                CodeOrProprietary = new BeneficialStrategies.Iso20022.Choices.DocumentType2Choice.Proprietary
                {
                    Value = "MYDOCTYPE",
                },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
