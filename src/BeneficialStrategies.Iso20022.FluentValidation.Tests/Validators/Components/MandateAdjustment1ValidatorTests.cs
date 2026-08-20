// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateAdjustment1ValidatorTests
{
    private readonly MandateAdjustment1Validator _sut = new();

    private static MandateAdjustment1 ValidMessage() => new() { DateAdjustmentRuleIndicator = true };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Category_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            Category = new BeneficialStrategies.Iso20022.Choices.Frequency37Choice.Proprietary
            {
                Value = "MYFREQ",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
