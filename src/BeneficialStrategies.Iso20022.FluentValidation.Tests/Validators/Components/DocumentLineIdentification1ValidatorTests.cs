// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DocumentLineIdentification1ValidatorTests
{
    private readonly DocumentLineIdentification1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new DocumentLineIdentification1()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new DocumentLineIdentification1
        {
            Type = new DocumentLineType1
            {
                CodeOrProprietary = new BeneficialStrategies.Iso20022.Choices.DocumentLineType1Choice.Proprietary
                {
                    Value = "MYLINETYPE",
                },
            },
            Number = "LINE-001",
            RelatedDate = new DateOnly(2026, 1, 1),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
