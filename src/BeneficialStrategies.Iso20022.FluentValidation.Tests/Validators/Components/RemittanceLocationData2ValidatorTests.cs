// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class RemittanceLocationData2ValidatorTests
{
    private readonly RemittanceLocationData2Validator _sut = new();

    private static RemittanceLocationData2 ValidMessage() =>
        new() { Method = RemittanceLocationMethod2Code.Fax };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            ElectronicAddress = "remit@example.com",
            PostalAddress = new NameAndAddress18 { Name = "Remit Co", Address = new PostalAddress27() },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
