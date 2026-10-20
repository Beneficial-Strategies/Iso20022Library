// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.Amount2Choice.Valid;

/// <summary>Valid samples of <c>AmountWithoutCurrency</c> of <c>Amount2Choice</c>.</summary>
public static class AmountWithoutCurrency
{
    /// <summary>A valid <c>AmountWithoutCurrency</c> of <c>Amount2Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.Amount2Choice.IAmountWithoutCurrency Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.Amount2Choice.IAmountWithoutCurrency>(b => b
                .Set(x => x.Value).To(100m));
}
