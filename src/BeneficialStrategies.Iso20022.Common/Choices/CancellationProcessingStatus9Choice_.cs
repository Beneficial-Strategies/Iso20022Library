// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of cancellation processing status.
    /// </summary>
    [KnownType(typeof(CancellationProcessingStatus9Choice.Code))]
    [KnownType(typeof(CancellationProcessingStatus9Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationProcessingStatus9Choice.Code),
        nameof(CancellationProcessingStatus9Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationProcessingStatus9Choice.Proprietary),
        nameof(CancellationProcessingStatus9Choice.Proprietary)
    )]
    [IsoId("_BlUUkeFfEeWIA4E9cYSxxQ")]
    [DisplayName("Cancellation Processing Status 9 Choice")]
    public abstract record CancellationProcessingStatus9Choice_ { }
}
