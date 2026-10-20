// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.StandingOrderOrAll4Choice.Valid;

/// <summary>Valid samples of <c>AllStandingOrders</c> of <c>StandingOrderOrAll4Choice</c>.</summary>
public static class AllStandingOrders
{
    /// <summary>A valid <c>AllStandingOrders</c> of <c>StandingOrderOrAll4Choice</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll4Choice.IAllStandingOrders Minimal =>
        IsoDataFactory.Make<Choices.StandingOrderOrAll4Choice.IAllStandingOrders>(b => b
            .Set(x => x.Value).To(BeneficialStrategies.Iso20022.Samples.StandingOrderIdentification9.Valid.Standard.Minimal));
}
