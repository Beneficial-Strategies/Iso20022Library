// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.RejectedStatus63Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between no specified reason and a reason for rejected status.</summary>
    [IsoId("_0ACaQd78Ee-NrtAAlrBEgQ")]
    [DisplayName("Rejected Status 63 Choice")]
    [KnownType(typeof(RejectedStatus63Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus63Choice.Reason))]
    [JsonDerivedType(typeof(RejectedStatus63Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectedStatus63Choice.Reason))]
    public abstract record RejectedStatus63Choice_
    {
    }
}
