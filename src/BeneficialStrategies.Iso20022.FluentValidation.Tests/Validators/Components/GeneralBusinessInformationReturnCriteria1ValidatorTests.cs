// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GeneralBusinessInformationReturnCriteria1ValidatorTests
{
    private readonly GeneralBusinessInformationReturnCriteria1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new GeneralBusinessInformationReturnCriteria1()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllFields_Present_NoValidationError()
    {
        var msg = new GeneralBusinessInformationReturnCriteria1
        {
            QualifierIndicator = true,
            SubjectIndicator = true,
            SubjectDetailsIndicator = false,
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
