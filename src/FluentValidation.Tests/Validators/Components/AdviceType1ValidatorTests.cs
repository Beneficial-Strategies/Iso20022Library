// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AdviceType1ValidatorTests
{
    private readonly AdviceType1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new AdviceType1()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new AdviceType1
        {
            CreditAdvice = new BeneficialStrategies.Iso20022.Choices.AdviceType1Choice.Code
            {
                Value = AdviceType1Code.AdviceWithDetails,
            },
            DebitAdvice = new BeneficialStrategies.Iso20022.Choices.AdviceType1Choice.Proprietary { Value = "DEBIT" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
