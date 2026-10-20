// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.Amount2Choice.Valid;

/// <summary>Valid samples of the <c>AmountWithCurrency</c> variant of <c>Amount2Choice</c>.</summary>
public static class AmountWithCurrency
{
    /// <summary>The AmountWithCurrency variant of <c>Amount2Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.Amount2Choice.IAmountWithCurrency Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.Amount2Choice.IAmountWithCurrency>(b => b
                .Set(x => x.Currency).To("USD")
                .Set(x => x.Amount).To(100m));
}
