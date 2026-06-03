// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RejectedReason66Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a code or proprietary format for a rejected reason.</summary>
    [IsoId("d92d6490-1886-44fa-bdb9-44f79da2ee23")]
    [DisplayName("Rejected Reason 66 Choice")]
    [KnownType(typeof(RejectedReason66Choice.Code))]
    [KnownType(typeof(RejectedReason66Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason66Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason66Choice.Proprietary))]
    public abstract record RejectedReason66Choice_
    {
    }
}
