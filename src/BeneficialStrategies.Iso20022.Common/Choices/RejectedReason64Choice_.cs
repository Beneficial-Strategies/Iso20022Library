// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RejectedReason64Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a code or proprietary format for a rejected reason.</summary>
    [IsoId("_j6af898PEe-NrtAAlrBEgQ")]
    [DisplayName("Rejected Reason 64 Choice")]
    [KnownType(typeof(RejectedReason64Choice.Code))]
    [KnownType(typeof(RejectedReason64Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason64Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason64Choice.Proprietary))]
    public abstract record RejectedReason64Choice_
    {
    }
}
