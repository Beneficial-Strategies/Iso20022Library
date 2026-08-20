// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ReferredMandateDocument2ValidatorTests
{
    private readonly ReferredMandateDocument2Validator _sut = new();

    private static ReferredMandateDocument2 ValidMessage() => new();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            RelatedDate = new DateAndType1
            {
                Date = new DateOnly(2026, 1, 1),
                Type = new BeneficialStrategies.Iso20022.Choices.DateType2Choice.Proprietary
                {
                    Value = "MYDATETYPE",
                },
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
