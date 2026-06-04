// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RejectedStatus64Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a reason and no reason for the general meeting instruction processing rejected status.</summary>
    [IsoId("_48GC8aKsEfCHi7w3_0pcpw")]
    [DisplayName("Rejected Status 64 Choice")]
    [KnownType(typeof(RejectedStatus64Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus64Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus64Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus64Choice.Reason))]
    public abstract record RejectedStatus64Choice_
    {
    }
}
