// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CreditorReferenceInformation3ValidatorTests
{
    private readonly CreditorReferenceInformation3Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new CreditorReferenceInformation3()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new CreditorReferenceInformation3
        {
            Reference = "REF-001",
            Type = new CreditorReferenceType3
            {
                CodeOrProprietary = new BeneficialStrategies.Iso20022.Choices.CreditorReferenceType2Choice.Proprietary
                {
                    Value = "MYREFTYPE",
                },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
