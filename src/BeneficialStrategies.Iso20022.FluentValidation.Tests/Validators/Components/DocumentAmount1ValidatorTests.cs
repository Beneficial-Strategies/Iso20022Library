// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DocumentAmount1ValidatorTests
{
    private readonly DocumentAmount1Validator _sut = new();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        var msg = new DocumentAmount1
        {
            Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            Type = new BeneficialStrategies.Iso20022.Choices.DocumentAmountType1Choice.Proprietary
            {
                Value = "MYAMTTYPE",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
