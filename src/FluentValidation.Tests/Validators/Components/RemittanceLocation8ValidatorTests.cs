// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class RemittanceLocation8ValidatorTests
{
    private readonly RemittanceLocation8Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new RemittanceLocation8()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new RemittanceLocation8
        {
            RemittanceIdentification = "RMT-001",
            RemittanceLocationDetails = [new RemittanceLocationData2 { Method = RemittanceLocationMethod2Code.Fax }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
