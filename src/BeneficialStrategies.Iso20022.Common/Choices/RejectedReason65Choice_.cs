// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RejectedReason65Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a code or proprietary format for a rejected reason.</summary>
    [IsoId("_CmwMAd79Ee-NrtAAlrBEgQ")]
    [DisplayName("Rejected Reason 65 Choice")]
    [KnownType(typeof(RejectedReason65Choice.Code))]
    [KnownType(typeof(RejectedReason65Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason65Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason65Choice.Proprietary))]
    public abstract record RejectedReason65Choice_
    {
    }
}
