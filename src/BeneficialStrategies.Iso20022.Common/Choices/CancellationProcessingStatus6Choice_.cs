// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status for the cancellation processing.
    /// </summary>
    [KnownType(typeof(CancellationProcessingStatus6Choice.CancellationPending))]
    [KnownType(typeof(CancellationProcessingStatus6Choice.CancellationRequested))]
    [KnownType(typeof(CancellationProcessingStatus6Choice.CancellationCompleted))]
    [KnownType(typeof(CancellationProcessingStatus6Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(CancellationProcessingStatus6Choice.CancellationPending),
        nameof(CancellationProcessingStatus6Choice.CancellationPending)
    )]
    [JsonDerivedType(
        typeof(CancellationProcessingStatus6Choice.CancellationRequested),
        nameof(CancellationProcessingStatus6Choice.CancellationRequested)
    )]
    [JsonDerivedType(
        typeof(CancellationProcessingStatus6Choice.CancellationCompleted),
        nameof(CancellationProcessingStatus6Choice.CancellationCompleted)
    )]
    [JsonDerivedType(
        typeof(CancellationProcessingStatus6Choice.ProprietaryStatus),
        nameof(CancellationProcessingStatus6Choice.ProprietaryStatus)
    )]
    [IsoId("_A4HJMtokEeC60axPepSq7g_1947058911")]
    [DisplayName("Cancellation Processing Status 6 Choice")]
    public abstract record CancellationProcessingStatus6Choice_ { }
}
