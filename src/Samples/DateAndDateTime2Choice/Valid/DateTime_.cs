// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.DateAndDateTime2Choice.Valid;

/// <summary>Valid samples of the <c>DateTime</c> variant of <c>DateAndDateTime2Choice</c>.</summary>
public static class DateTime_
{
    /// <summary>The DateTime variant of <c>DateAndDateTime2Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.IDateTime Minimal =>
        IsoDataFactory.Make<BeneficialStrategies.Iso20022.Choices.DateAndDateTime2Choice.IDateTime>(b => b
                .Set(x => x.Value).To(new System.DateTime(2026, 1, 1)));
}
