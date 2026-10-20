// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.AmountType4Choice.Valid;

/// <summary>Valid samples of the <c>InstructedAmount</c> variant of <c>AmountType4Choice</c>.</summary>
public static class InstructedAmount
{
    /// <summary>The InstructedAmount variant of <c>AmountType4Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.AmountType4Choice.IInstructedAmount Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.AmountType4Choice.IInstructedAmount>(b => b
                .Set(x => x.Currency).To("USD")
                .Set(x => x.Amount).To(100m));
}
