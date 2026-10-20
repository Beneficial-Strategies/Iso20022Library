// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class RemittanceInformation2ValidatorTests
{
    private readonly RemittanceInformation2Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new RemittanceInformation2()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Unstructured_Present_NoValidationErrors()
    {
        var msg = new RemittanceInformation2 { Unstructured = ["Invoice 12345"] };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
