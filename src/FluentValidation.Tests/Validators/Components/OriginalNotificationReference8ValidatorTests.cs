// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class OriginalNotificationReference8ValidatorTests
{
    private readonly OriginalNotificationReference8Validator _sut = new();

    private static ICashAccount24 ValidAccount(string id = "ACC-001") =>
        IsoDataFactory.Make<ICashAccount24>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IOther>(b2 => b2
                .Set(x2 => x2.Identification).To(id))));

    private static IOriginalItem5 MinimalItem(string currency = "USD", decimal amount = 100m) =>
        IsoDataFactory.Make<IOriginalItem5>(b => b
            .Set(x => x.OriginalItemIdentification).To("ITEM-001")
            .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = currency, Amount = amount }));

    private static IOriginalNotificationReference8 ValidMessage() => IsoDataFactory.Make<IOriginalNotificationReference8>(b => b
        .Set(x => x.OriginalItem).To([MinimalItem()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── OriginalItem: 1..* ────────────────────────────────────────────────────

    [Fact]
    public void OriginalItem_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalItem).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.OriginalItem);
    }

    // ── ExpectedValueDateRule ────────────────────────────────────────────────

    [Fact]
    public void ExpectedValueDateAndItemExpectedValueDate_Violates_ExpectedValueDateRule()
    {
        var date = new DateOnly(2026, 8, 13);
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ExpectedValueDate).To(date)
            .Set(x => x.OriginalItem).To([IsoDataFactory.With(MinimalItem(), b2 => b2
                .Set(x2 => x2.ExpectedValueDate).To(date))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ExpectedValueDateRule");
    }

    [Fact]
    public void ExpectedValueDateOnly_DoesNotViolate_ExpectedValueDateRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ExpectedValueDate).To(new DateOnly(2026, 8, 13)));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ExpectedValueDateRule");
    }

    // ── TotalAmountAndAmount1Rule: currency must match TotalAmount ──────────

    [Fact]
    public void TotalAmountCurrencyMismatch_Violates_TotalAmountAndAmount1Rule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TotalAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 100m })
            .Set(x => x.OriginalItem).To([MinimalItem(currency: "USD", amount: 100m)]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalAmountAndAmount1Rule");
    }

    [Fact]
    public void TotalAmountCurrencyMatches_DoesNotViolate_TotalAmountAndAmount1Rule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TotalAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.OriginalItem).To([MinimalItem(currency: "USD", amount: 100m)]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "TotalAmountAndAmount1Rule");
    }

    // ── TotalAmountAndAmount2Rule: TotalAmount must equal sum of OriginalItem/Amount ─

    [Fact]
    public void TotalAmountNotEqualToSum_Violates_TotalAmountAndAmount2Rule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TotalAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 999m })
            .Set(x => x.OriginalItem).To([MinimalItem(amount: 100m)]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalAmountAndAmount2Rule");
    }

    [Fact]
    public void TotalAmountEqualToSum_DoesNotViolate_TotalAmountAndAmount2Rule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TotalAmount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
            .Set(x => x.OriginalItem).To([MinimalItem(amount: 100m)]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "TotalAmountAndAmount2Rule");
    }

    // ── AccountAndCurrencyRule: all OriginalItem/Amount share the same currency ─

    [Fact]
    public void AccountPresentWithMixedItemCurrencies_Violates_AccountAndCurrencyRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Account).To(ValidAccount())
            .Set(x => x.OriginalItem).To([MinimalItem(currency: "USD"), MinimalItem(currency: "EUR")]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "AccountAndCurrencyRule");
    }

    [Fact]
    public void AccountPresentWithConsistentItemCurrencies_DoesNotViolate_AccountAndCurrencyRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Account).To(ValidAccount())
            .Set(x => x.OriginalItem).To([MinimalItem(currency: "USD"), MinimalItem(currency: "USD")]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "AccountAndCurrencyRule");
    }
}
