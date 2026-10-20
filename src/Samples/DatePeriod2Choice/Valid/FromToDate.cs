// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.DatePeriod2Choice.Valid;

/// <summary>Valid samples of <c>FromToDate</c> of <c>DatePeriod2Choice</c>.</summary>
public static class FromToDate
{
    /// <summary>A valid <c>FromToDate</c> of <c>DatePeriod2Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.DatePeriod2Choice.IFromToDate Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.DatePeriod2Choice.IFromToDate>(b => b
                .Set(x => x.FromDate).To(new System.DateOnly(2026, 1, 1))
                .Set(x => x.ToDate).To(new System.DateOnly(2026, 12, 31)));
}
