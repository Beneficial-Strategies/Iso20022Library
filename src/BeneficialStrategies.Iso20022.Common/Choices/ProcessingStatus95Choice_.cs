// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus95Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus95Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus95Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ProcessingStatus95Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus95Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus95Choice.Rejected),
        nameof(ProcessingStatus95Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus95Choice.Proprietary),
        nameof(ProcessingStatus95Choice.Proprietary)
    )]
    [IsoId("_gBIawzi8Eeydid5dcNPKvg")]
    [DisplayName("Processing Status 95 Choice")]
    public abstract record ProcessingStatus95Choice_ { }
}
