// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RejectedReason70Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a code or proprietary format for a rejected reason.</summary>
    [IsoId("_ETYKM6jVEfCzuLlmLrhIvA")]
    [DisplayName("Rejected Reason 70 Choice")]
    [KnownType(typeof(RejectedReason70Choice.Code))]
    [KnownType(typeof(RejectedReason70Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason70Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason70Choice.Proprietary))]
    public abstract record RejectedReason70Choice_
    {
    }
}
