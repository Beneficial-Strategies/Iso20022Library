// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingReason83Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.</summary>
    [IsoId("_HNklybMaEfCEXew4g5B5oA")]
    [DisplayName("Pending Reason 83 Choice")]
    [KnownType(typeof(PendingReason83Choice.Code))]
    [KnownType(typeof(PendingReason83Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason83Choice.Code))]
    [JsonDerivedType(typeof(PendingReason83Choice.Proprietary))]
    public abstract record PendingReason83Choice_
    {
    }
}
