// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.AmountType4Choice.Valid;

/// <summary>Valid samples of <c>EquivalentAmount</c> of <c>AmountType4Choice</c>.</summary>
public static class EquivalentAmount
{
    /// <summary>A valid <c>EquivalentAmount</c> of <c>AmountType4Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.AmountType4Choice.IEquivalentAmount Minimal =>
        IsoDataFactory.Make<Choices.AmountType4Choice.IEquivalentAmount>(b => b
                .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
                .Set(x => x.CurrencyOfTransfer).To("EUR"));

    /// <summary>A valid <c>EquivalentAmount</c> of <c>AmountType4Choice</c> with more members set than Minimal. A new object on every access.</summary>
    public static Choices.AmountType4Choice.IEquivalentAmount Maximal =>
        IsoDataFactory.Make<Choices.AmountType4Choice.IEquivalentAmount>(b => b
                .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
                .Set(x => x.CurrencyOfTransfer).To("ZZZ"));
}
