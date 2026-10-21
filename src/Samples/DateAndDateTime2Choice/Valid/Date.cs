// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.DateAndDateTime2Choice.Valid;

/// <summary>Valid samples of <c>Date</c> of <c>DateAndDateTime2Choice</c>.</summary>
public static class Date
{
    /// <summary>A valid <c>Date</c> of <c>DateAndDateTime2Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.DateAndDateTime2Choice.IDate Minimal =>
        IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b => b
                .Set(x => x.Value).To(new System.DateOnly(2026, 1, 1)));
}
