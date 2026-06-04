// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingStatus85Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a reason or no reason for the corporate action instruction processing pending status.</summary>
    [IsoId("_iPJyMbMZEfCEXew4g5B5oA")]
    [DisplayName("Pending Status 85 Choice")]
    [KnownType(typeof(PendingStatus85Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus85Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus85Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus85Choice.Reason))]
    public abstract record PendingStatus85Choice_
    {
    }
}
