// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status is cancelled.
    /// </summary>
    [KnownType(typeof(CancellationStatus22Choice.Status))]
    [KnownType(typeof(CancellationStatus22Choice.Rejected))]
    [JsonDerivedType(
        typeof(CancellationStatus22Choice.Status),
        nameof(CancellationStatus22Choice.Status)
    )]
    [JsonDerivedType(
        typeof(CancellationStatus22Choice.Rejected),
        nameof(CancellationStatus22Choice.Rejected)
    )]
    [IsoId("_kZs-EEgsEeaD2L_hzZaE0w")]
    [DisplayName("Cancellation Status 22 Choice")]
    public abstract record CancellationStatus22Choice_ { }
}
