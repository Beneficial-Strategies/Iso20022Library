// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.Amount2Choice.Valid;

/// <summary>Valid samples of <c>AmountWithoutCurrency</c> of <c>Amount2Choice</c>.</summary>
public static class AmountWithoutCurrency
{
    /// <summary>A valid <c>AmountWithoutCurrency</c> of <c>Amount2Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.Amount2Choice.IAmountWithoutCurrency Minimal =>
        IsoDataFactory.Make<Choices.Amount2Choice.IAmountWithoutCurrency>(b => b
                .Set(x => x.Value).To(100m));
}
