// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus67Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus67Choice.Repair))]
    [KnownType(typeof(ProcessingStatus67Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus67Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus67Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ProcessingStatus67Choice.Rejected),
        nameof(ProcessingStatus67Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus67Choice.Repair),
        nameof(ProcessingStatus67Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus67Choice.Cancelled),
        nameof(ProcessingStatus67Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus67Choice.AcknowledgedAccepted),
        nameof(ProcessingStatus67Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(ProcessingStatus67Choice.Proprietary),
        nameof(ProcessingStatus67Choice.Proprietary)
    )]
    [IsoId("_W7Icl-FUEeWIA4E9cYSxxQ")]
    [DisplayName("Processing Status 67 Choice")]
    public abstract record ProcessingStatus67Choice_ { }
}
