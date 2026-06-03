// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingReason75Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the pending reason.</summary>
    [IsoId("_YE220eSkEe-qVZLXW4RRBw")]
    [DisplayName("Pending Reason 75 Choice")]
    [KnownType(typeof(PendingReason75Choice.Code))]
    [KnownType(typeof(PendingReason75Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason75Choice.Code))]
    [JsonDerivedType(typeof(PendingReason75Choice.Proprietary))]
    public abstract record PendingReason75Choice_
    {
    }
}
