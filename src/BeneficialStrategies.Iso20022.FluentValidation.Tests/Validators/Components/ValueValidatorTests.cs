// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ValueValidatorTests
{
    private readonly ValueValidator _sut = new();

    private static Value ValidMessage() =>
        new()
        {
            BaseCurrencyItem = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            AlternateCurrencyItem = [new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 90m }],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── AlternateCurrencyItem: ActiveOrHistoricCurrencyAndAmount, 1..∞ ────────

    [Fact]
    public void AlternateCurrencyItem_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { AlternateCurrencyItem = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.AlternateCurrencyItem);
    }

    [Fact]
    public void AlternateCurrencyItem_OneElement_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            AlternateCurrencyItem = [new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 90m }],
        };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.AlternateCurrencyItem);
    }
}
