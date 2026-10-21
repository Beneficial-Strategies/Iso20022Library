// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.AmountAndDirection5.Valid;

/// <summary>Valid samples of <c>AmountAndDirection5</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>AmountAndDirection5</c> with the required members set. A new object on every access.</summary>
    public static Components.IAmountAndDirection5 Minimal =>
        IsoDataFactory.Make<IAmountAndDirection5>(b => b
            .Set(x => x.Amount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m }));
}
