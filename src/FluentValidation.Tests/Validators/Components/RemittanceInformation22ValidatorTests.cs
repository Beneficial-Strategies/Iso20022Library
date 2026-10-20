// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class RemittanceInformation22ValidatorTests
{
    private readonly RemittanceInformation22Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new RemittanceInformation22()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new RemittanceInformation22
        {
            Unstructured = ["Payment for invoice 123"],
            Structured = [new StructuredRemittanceInformation18()],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
