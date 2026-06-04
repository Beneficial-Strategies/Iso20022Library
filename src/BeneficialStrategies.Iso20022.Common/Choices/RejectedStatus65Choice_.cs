// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RejectedStatus65Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a reason and no reason for the corporate action instruction processing rejected status.</summary>
    [IsoId("_VvENIaKvEfCHi7w3_0pcpw")]
    [DisplayName("Rejected Status 65 Choice")]
    [KnownType(typeof(RejectedStatus65Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus65Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus65Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus65Choice.Reason))]
    public abstract record RejectedStatus65Choice_
    {
    }
}
