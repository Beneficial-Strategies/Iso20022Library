// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of cancellation processing status.
    /// </summary>
    [KnownType(typeof(CancellationProcessingStatus8Choice.Code))]
    [KnownType(typeof(CancellationProcessingStatus8Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationProcessingStatus8Choice.Code),nameof(CancellationProcessingStatus8Choice.Code))]
    [JsonDerivedType(typeof(CancellationProcessingStatus8Choice.Proprietary),nameof(CancellationProcessingStatus8Choice.Proprietary))]
    [IsoId("_8QcPjZNLEeWGlc8L7oPDIg")]
    [DisplayName("Cancellation Processing Status 8 Choice")]
    public abstract partial record CancellationProcessingStatus8Choice_
    {
    }
}
