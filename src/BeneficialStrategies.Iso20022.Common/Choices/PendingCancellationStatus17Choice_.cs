// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus17Choice;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a reason or no reason for the corporate action instruction cancellation pending cancellation status.</summary>
    [IsoId("_dUzoYd8QEe-NrtAAlrBEgQ")]
    [DisplayName("Pending Cancellation Status 17 Choice")]
    [KnownType(typeof(NotSpecifiedReason))]
    [KnownType(typeof(Reason))]
    [JsonDerivedType(typeof(NotSpecifiedReason))]
    [JsonDerivedType(typeof(Reason))]
    public abstract record PendingCancellationStatus17Choice_;
}
