// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RejectedReason69Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a code or proprietary format for a rejected reason.</summary>
    [IsoId("_HbeLsaKvEfCHi7w3_0pcpw")]
    [DisplayName("Rejected Reason 69 Choice")]
    [KnownType(typeof(RejectedReason69Choice.Code))]
    [KnownType(typeof(RejectedReason69Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason69Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason69Choice.Proprietary))]
    public abstract record RejectedReason69Choice_
    {
    }
}
