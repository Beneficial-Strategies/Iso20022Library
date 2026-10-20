// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ChargesRecord5ValidatorTests
{
    private readonly ChargesRecord5Validator _sut = new();

    private static ChargesRecord5 ValidMessage() =>
        new()
        {
            Amount = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 10m },
            UnderlyingTransaction = [new TransactionReferences7()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── UnderlyingTransaction: TransactionReferences7, 1..∞ ───────────────────

    [Fact]
    public void UnderlyingTransaction_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { UnderlyingTransaction = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.UnderlyingTransaction);
    }

    [Fact]
    public void UnderlyingTransaction_OneElement_NoValidationError()
    {
        var msg = ValidMessage() with { UnderlyingTransaction = [new TransactionReferences7()] };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.UnderlyingTransaction);
    }
}
