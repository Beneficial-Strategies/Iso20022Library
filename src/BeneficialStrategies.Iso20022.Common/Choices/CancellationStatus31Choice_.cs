// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Cancellation Status31Choice.
    /// </summary>
    [KnownType(typeof(CancellationStatus31Choice.DetailedCancellationStatus))]
    [KnownType(typeof(CancellationStatus31Choice.GlobalCancellationStatus))]
    [JsonDerivedType(
        typeof(CancellationStatus31Choice.DetailedCancellationStatus),
        nameof(CancellationStatus31Choice.DetailedCancellationStatus)
    )]
    [JsonDerivedType(
        typeof(CancellationStatus31Choice.GlobalCancellationStatus),
        nameof(CancellationStatus31Choice.GlobalCancellationStatus)
    )]
    [IsoId("_pjSfhYYQEe-9jM3-w7OB3g")]
    [DisplayName("Cancellation Status31Choice")]
    public abstract record CancellationStatus31Choice_ { }
}
