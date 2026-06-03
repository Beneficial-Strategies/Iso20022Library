// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying to the instruction cancellation request received.
    /// </summary>
    [KnownType(typeof(CancellationStatus35Choice.ProcessingStatus))]
    [KnownType(typeof(CancellationStatus35Choice.Rejected))]
    [KnownType(typeof(CancellationStatus35Choice.PendingCancellation))]
    [JsonDerivedType(typeof(CancellationStatus35Choice.ProcessingStatus), nameof(CancellationStatus35Choice.ProcessingStatus))]
    [JsonDerivedType(typeof(CancellationStatus35Choice.Rejected), nameof(CancellationStatus35Choice.Rejected))]
    [JsonDerivedType(typeof(CancellationStatus35Choice.PendingCancellation), nameof(CancellationStatus35Choice.PendingCancellation))]
    [IsoId("_c89Xka8uEfCx2aBifPEdRg")]
    [DisplayName("CancellationStatus35Choice")]
    public abstract record CancellationStatus35Choice_ { }
}
