// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class InformationQualifierType1ValidatorTests
{
    private readonly InformationQualifierType1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new InformationQualifierType1()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllFields_Present_NoValidationError()
    {
        var msg = new InformationQualifierType1 { IsFormatted = true, Priority = Priority1Code.High };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
