// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RejectedReason68Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a code or proprietary format for a rejected reason.</summary>
    [IsoId("_pMsx4aKsEfCHi7w3_0pcpw")]
    [DisplayName("Rejected Reason 68 Choice")]
    [KnownType(typeof(RejectedReason68Choice.Code))]
    [KnownType(typeof(RejectedReason68Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectedReason68Choice.Code))]
    [JsonDerivedType(typeof(RejectedReason68Choice.Proprietary))]
    public abstract record RejectedReason68Choice_
    {
    }
}
