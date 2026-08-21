// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class RemittanceInformation26ValidatorTests
{
    private readonly RemittanceInformation26Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new RemittanceInformation26()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new RemittanceInformation26
        {
            Unstructured = ["Payment for invoice 123"],
            Structured = [new StructuredRemittanceInformation22()],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
