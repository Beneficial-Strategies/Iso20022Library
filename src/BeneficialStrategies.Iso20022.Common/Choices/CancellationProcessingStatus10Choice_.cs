// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status for the cancellation processing.
    /// </summary>
    [KnownType(typeof(CancellationProcessingStatus10Choice.CancellationPending))]
    [KnownType(typeof(CancellationProcessingStatus10Choice.CancellationRequested))]
    [KnownType(typeof(CancellationProcessingStatus10Choice.CancellationCompleted))]
    [KnownType(typeof(CancellationProcessingStatus10Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(CancellationProcessingStatus10Choice.CancellationPending),nameof(CancellationProcessingStatus10Choice.CancellationPending))]
    [JsonDerivedType(typeof(CancellationProcessingStatus10Choice.CancellationRequested),nameof(CancellationProcessingStatus10Choice.CancellationRequested))]
    [JsonDerivedType(typeof(CancellationProcessingStatus10Choice.CancellationCompleted),nameof(CancellationProcessingStatus10Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(CancellationProcessingStatus10Choice.ProprietaryStatus),nameof(CancellationProcessingStatus10Choice.ProprietaryStatus))]
    [IsoId("_livbgQd4Ee2fOITqoTnSLQ")]
    [DisplayName("Cancellation Processing Status 10 Choice")]
    public abstract partial record CancellationProcessingStatus10Choice_
    {
    }
}
