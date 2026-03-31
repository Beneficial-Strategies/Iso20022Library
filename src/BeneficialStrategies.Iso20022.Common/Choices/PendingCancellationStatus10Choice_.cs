// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction cancellation pending cancellation status.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus10Choice.NotSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus10Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingCancellationStatus10Choice.NotSpecifiedReason),
        nameof(PendingCancellationStatus10Choice.NotSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingCancellationStatus10Choice.Reason),
        nameof(PendingCancellationStatus10Choice.Reason)
    )]
    [IsoId("__KUE-bKiEemux5trsZcCpw")]
    [DisplayName("Pending Cancellation Status 10 Choice")]
    public abstract record PendingCancellationStatus10Choice_ { }
}
