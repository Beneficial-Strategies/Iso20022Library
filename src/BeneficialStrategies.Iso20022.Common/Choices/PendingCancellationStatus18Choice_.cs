// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.PendingCancellationStatus18Choice;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between a reason or no reason for the corporate action instruction cancellation pending cancellation status.</summary>
    [IsoId("_vnHNkaLNEfCHi7w3_0pcpw")]
    [DisplayName("Pending Cancellation Status 18 Choice")]
    [KnownType(typeof(NoSpecifiedReason))]
    [KnownType(typeof(Reason))]
    [JsonDerivedType(typeof(NoSpecifiedReason))]
    [JsonDerivedType(typeof(Reason))]
    public abstract record PendingCancellationStatus18Choice_;
}
