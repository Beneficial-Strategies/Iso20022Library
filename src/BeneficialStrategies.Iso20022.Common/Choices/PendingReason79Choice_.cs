// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingReason79Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the pending reason.</summary>
    [IsoId("_vBCzjaodEfCG2_q2WT-90w")]
    [DisplayName("Pending Reason 79 Choice")]
    [KnownType(typeof(PendingReason79Choice.Code))]
    [KnownType(typeof(PendingReason79Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason79Choice.Code))]
    [JsonDerivedType(typeof(PendingReason79Choice.Proprietary))]
    public abstract record PendingReason79Choice_
    {
    }
}
