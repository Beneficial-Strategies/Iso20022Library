// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.AmountType4Choice.Valid;

/// <summary>Valid samples of <c>InstructedAmount</c> of <c>AmountType4Choice</c>.</summary>
public static class InstructedAmount
{
    /// <summary>A valid <c>InstructedAmount</c> of <c>AmountType4Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static Choices.AmountType4Choice.IInstructedAmount Minimal =>
        IsoDataFactory.Make<Choices.AmountType4Choice.IInstructedAmount>(b => b
                .Set(x => x.Currency).To("USD")
                .Set(x => x.Amount).To(100m));
}
