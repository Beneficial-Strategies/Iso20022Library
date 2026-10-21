// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.AmountOrRate1Choice.Valid;

/// <summary>Valid samples of <c>Rate</c> of <c>AmountOrRate1Choice</c>.</summary>
public static class Rate
{
    /// <summary>A valid <c>Rate</c> of <c>AmountOrRate1Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.AmountOrRate1Choice.IRate Minimal =>
        IsoDataFactory.Make<Choices.AmountOrRate1Choice.IRate>(b => b
                .Set(x => x.Value).To(5.5m));
}
