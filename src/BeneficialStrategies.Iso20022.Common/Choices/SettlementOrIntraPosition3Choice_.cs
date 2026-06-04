// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.SettlementOrIntraPosition3Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between the intra-position movement or the settlement transaction.</summary>
    [IsoId("_TUEdQWp9EemmaZLSPtWX5A")]
    [DisplayName("Settlement Or Intra Position 3 Choice")]
    [KnownType(typeof(SettlementOrIntraPosition3Choice.IntraPositionMovement))]
    [KnownType(typeof(SettlementOrIntraPosition3Choice.SettlementTransaction))]
    [JsonDerivedType(typeof(SettlementOrIntraPosition3Choice.IntraPositionMovement))]
    [JsonDerivedType(typeof(SettlementOrIntraPosition3Choice.SettlementTransaction))]
    public abstract record SettlementOrIntraPosition3Choice_
    {
    }
}
