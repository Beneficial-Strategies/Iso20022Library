// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class StatusReason6Choice_ValidatorTests
{
    private readonly StatusReason6Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.StatusReason6Choice.Code
        {
            Value = ExternalStatusReason1Code.AbortedClearingTimeout,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.StatusReason6Choice.Proprietary
        {
            Value = "MYSTATUSREASON",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
