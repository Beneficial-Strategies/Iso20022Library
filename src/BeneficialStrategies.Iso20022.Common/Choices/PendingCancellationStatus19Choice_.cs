// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus19Choice;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a reason or no reason for the corporate action instruction cancellation pending cancellation status.</summary>
    [IsoId("_dFg2p68uEfCx2aBifPEdRg")]
    [DisplayName("Pending Cancellation Status 19 Choice")]
    [KnownType(typeof(NoSpecifiedReason))]
    [KnownType(typeof(Reason))]
    [JsonDerivedType(typeof(NoSpecifiedReason))]
    [JsonDerivedType(typeof(Reason))]
    public abstract record PendingCancellationStatus19Choice_;
}
