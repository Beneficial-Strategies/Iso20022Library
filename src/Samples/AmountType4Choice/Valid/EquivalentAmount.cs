// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.AmountType4Choice.Valid;

/// <summary>Valid samples of the <c>EquivalentAmount</c> variant of <c>AmountType4Choice</c>.</summary>
public static class EquivalentAmount
{
    /// <summary>The EquivalentAmount variant of <c>AmountType4Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.AmountType4Choice.IEquivalentAmount Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.AmountType4Choice.IEquivalentAmount>(b => b
                .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
                .Set(x => x.CurrencyOfTransfer).To("EUR"));

    /// <summary>The EquivalentAmount variant of <c>AmountType4Choice</c> with more members set than Minimal. A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.AmountType4Choice.IEquivalentAmount Maximal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.AmountType4Choice.IEquivalentAmount>(b => b
                .Set(x => x.Amount).To(new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m })
                .Set(x => x.CurrencyOfTransfer).To("ZZZ"));
}
