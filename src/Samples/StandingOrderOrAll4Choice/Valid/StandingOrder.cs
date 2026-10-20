// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.StandingOrderOrAll4Choice.Valid;

/// <summary>Valid samples of <c>StandingOrder</c> of <c>StandingOrderOrAll4Choice</c>.</summary>
public static class StandingOrder
{
    /// <summary>A valid <c>StandingOrder</c> of <c>StandingOrderOrAll4Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll4Choice.IStandingOrder Minimal =>
        IsoDataFactory.Make<Choices.StandingOrderOrAll4Choice.IStandingOrder>(b => b
            .Set(x => x.Value).To(BeneficialStrategies.Iso20022.Samples.StandingOrderIdentification8.Valid.Standard.Minimal));
}
