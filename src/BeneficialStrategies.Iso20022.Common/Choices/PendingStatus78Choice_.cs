// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingStatus78Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a reason or no reason for the corporate action instruction processing pending status.</summary>
    [IsoId("_47iKQd8EEe-NrtAAlrBEgQ")]
    [DisplayName("Pending Status 78 Choice")]
    [KnownType(typeof(PendingStatus78Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus78Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatus78Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatus78Choice.Reason))]
    public abstract record PendingStatus78Choice_
    {
    }
}
