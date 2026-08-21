// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class SecuritiesAttributes1ValidatorTests
{
    private readonly SecuritiesAttributes1Validator _sut = new();

    private static SecuritiesAttributes1 ValidMessage() =>
        new() { UniqueTransactionIdentifier = "ABCDEFGHIJKLMNOPQR12" };

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
            Amount = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
