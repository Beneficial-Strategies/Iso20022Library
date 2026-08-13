// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalNotificationReference14ValidatorTests
{
    private readonly OriginalNotificationReference14Validator _sut = new();

    private static CashAccount40 ValidAccount(string id = "ACC-001") =>
        new()
        {
            Identification = new Choices.AccountIdentification4Choice.Other { Identification = id },
        };

    private static OriginalItem8 MinimalItem(string currency = "USD", decimal amount = 100m) =>
        new()
        {
            OriginalItemIdentification = "ITEM-001",
            Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = currency, Amount = amount },
        };

    private static OriginalNotificationReference14 ValidMessage() => new() { OriginalItem = [MinimalItem()] };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalItem: 1..* ────────────────────────────────────────────────────

    [Fact]
    public void OriginalItem_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { OriginalItem = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.OriginalItem);
    }

    // ── ExpectedValueDateRule ────────────────────────────────────────────────

    [Fact]
    public void ExpectedValueDateAndItemExpectedValueDate_Violates_ExpectedValueDateRule()
    {
        var date = new DateOnly(2026, 8, 13);
        var msg = ValidMessage() with
        {
            ExpectedValueDate = date,
            OriginalItem = [MinimalItem() with { ExpectedValueDate = date }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ExpectedValueDateRule");
    }

    [Fact]
    public void ExpectedValueDateOnly_DoesNotViolate_ExpectedValueDateRule()
    {
        var msg = ValidMessage() with { ExpectedValueDate = new DateOnly(2026, 8, 13) };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ExpectedValueDateRule");
    }

    // ── TotalAmountAndAmount1Rule: currency must match TotalAmount ──────────

    [Fact]
    public void TotalAmountCurrencyMismatch_Violates_TotalAmountAndAmount1Rule()
    {
        var msg = ValidMessage() with
        {
            TotalAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 100m },
            OriginalItem = [MinimalItem(currency: "USD", amount: 100m)],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalAmountAndAmount1Rule");
    }

    [Fact]
    public void TotalAmountCurrencyMatches_DoesNotViolate_TotalAmountAndAmount1Rule()
    {
        var msg = ValidMessage() with
        {
            TotalAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            OriginalItem = [MinimalItem(currency: "USD", amount: 100m)],
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "TotalAmountAndAmount1Rule");
    }

    // ── TotalAmountAndAmount2Rule: TotalAmount must equal sum of OriginalItem/Amount ─

    [Fact]
    public void TotalAmountNotEqualToSum_Violates_TotalAmountAndAmount2Rule()
    {
        var msg = ValidMessage() with
        {
            TotalAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 999m },
            OriginalItem = [MinimalItem(amount: 100m)],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalAmountAndAmount2Rule");
    }

    [Fact]
    public void TotalAmountEqualToSum_DoesNotViolate_TotalAmountAndAmount2Rule()
    {
        var msg = ValidMessage() with
        {
            TotalAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            OriginalItem = [MinimalItem(amount: 100m)],
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "TotalAmountAndAmount2Rule");
    }

    // ── AccountAndCurrencyRule: all OriginalItem/Amount share the same currency ─

    [Fact]
    public void AccountPresentWithMixedItemCurrencies_Violates_AccountAndCurrencyRule()
    {
        var msg = ValidMessage() with
        {
            Account = ValidAccount(),
            OriginalItem = [MinimalItem(currency: "USD"), MinimalItem(currency: "EUR")],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "AccountAndCurrencyRule");
    }

    [Fact]
    public void AccountPresentWithConsistentItemCurrencies_DoesNotViolate_AccountAndCurrencyRule()
    {
        var msg = ValidMessage() with
        {
            Account = ValidAccount(),
            OriginalItem = [MinimalItem(currency: "USD"), MinimalItem(currency: "USD")],
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "AccountAndCurrencyRule");
    }
}
