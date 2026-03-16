// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Cancellation Status32Choice.
    /// </summary>
    [KnownType(typeof(CancellationStatus32Choice.PendingCancellation))]
    [KnownType(typeof(CancellationStatus32Choice.ProcessingStatus))]
    [KnownType(typeof(CancellationStatus32Choice.Rejected))]
    [JsonDerivedType(typeof(CancellationStatus32Choice.PendingCancellation),nameof(CancellationStatus32Choice.PendingCancellation))]
    [JsonDerivedType(typeof(CancellationStatus32Choice.ProcessingStatus),nameof(CancellationStatus32Choice.ProcessingStatus))]
    [JsonDerivedType(typeof(CancellationStatus32Choice.Rejected),nameof(CancellationStatus32Choice.Rejected))]
    [IsoId("_pvZB0YYQEe-9jM3-w7OB3g")]
    [DisplayName("Cancellation Status32Choice")]
    public abstract partial record CancellationStatus32Choice_
    {
    }
}
