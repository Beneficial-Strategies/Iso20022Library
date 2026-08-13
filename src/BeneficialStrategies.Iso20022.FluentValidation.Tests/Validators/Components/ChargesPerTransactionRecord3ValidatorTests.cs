// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ChargesPerTransactionRecord3ValidatorTests
{
    private readonly ChargesPerTransactionRecord3Validator _sut = new();

    private static ChargesBreakdown1 ValidBreakdown() =>
        new() { Amount = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 10m } };

    private static ChargesPerTransactionRecord3 ValidMessage() =>
        new() { UnderlyingTransaction = new TransactionReferences7(), ChargesBreakdown = [ValidBreakdown()] };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── ChargesBreakdown: ChargesBreakdown1, 1..∞ ─────────────────────────────

    [Fact]
    public void ChargesBreakdown_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { ChargesBreakdown = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.ChargesBreakdown);
    }

    [Fact]
    public void ChargesBreakdown_OneElement_NoValidationError()
    {
        var msg = ValidMessage() with { ChargesBreakdown = [ValidBreakdown()] };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.ChargesBreakdown);
    }
}
