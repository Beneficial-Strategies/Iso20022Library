// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of cancellation processing status.
    /// </summary>
    [KnownType(typeof(CancellationProcessingStatus7Choice.Code))]
    [KnownType(typeof(CancellationProcessingStatus7Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationProcessingStatus7Choice.Code),
        nameof(CancellationProcessingStatus7Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationProcessingStatus7Choice.Proprietary),
        nameof(CancellationProcessingStatus7Choice.Proprietary)
    )]
    [IsoId("_26ahETqqEeWyoP0PbocV1Q")]
    [DisplayName("Cancellation Processing Status 7 Choice")]
    public abstract record CancellationProcessingStatus7Choice_ { }
}
