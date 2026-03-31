// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying to the instruction cancellation request received.
    /// </summary>
    [KnownType(typeof(CancellationStatus26Choice.ProcessingStatus))]
    [KnownType(typeof(CancellationStatus26Choice.Rejected))]
    [KnownType(typeof(CancellationStatus26Choice.PendingCancellation))]
    [JsonDerivedType(
        typeof(CancellationStatus26Choice.ProcessingStatus),
        nameof(CancellationStatus26Choice.ProcessingStatus)
    )]
    [JsonDerivedType(
        typeof(CancellationStatus26Choice.Rejected),
        nameof(CancellationStatus26Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(CancellationStatus26Choice.PendingCancellation),
        nameof(CancellationStatus26Choice.PendingCancellation)
    )]
    [IsoId("_iKIapLKfEemux5trsZcCpw")]
    [DisplayName("Cancellation Status 26 Choice")]
    public abstract record CancellationStatus26Choice_ { }
}
