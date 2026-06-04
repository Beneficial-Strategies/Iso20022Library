// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RejectedStatus66Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a reason and no reason for the general meeting instruction processing rejected status.</summary>
    [IsoId("_EFISx6jVEfCzuLlmLrhIvA")]
    [DisplayName("Rejected Status 66 Choice")]
    [KnownType(typeof(RejectedStatus66Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus66Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus66Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus66Choice.Reason))]
    public abstract record RejectedStatus66Choice_
    {
    }
}
