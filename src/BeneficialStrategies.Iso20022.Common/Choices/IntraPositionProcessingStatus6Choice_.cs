// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(IntraPositionProcessingStatus6Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus6Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus6Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus6Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus6Choice.Proprietary))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus6Choice.Rejected),nameof(IntraPositionProcessingStatus6Choice.Rejected))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus6Choice.Repair),nameof(IntraPositionProcessingStatus6Choice.Repair))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus6Choice.Cancelled),nameof(IntraPositionProcessingStatus6Choice.Cancelled))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus6Choice.AcknowledgedAccepted),nameof(IntraPositionProcessingStatus6Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus6Choice.Proprietary),nameof(IntraPositionProcessingStatus6Choice.Proprietary))]
    [IsoId("_5SFAQ5NLEeWGlc8L7oPDIg")]
    [DisplayName("Intra Position Processing Status 6 Choice")]
    public abstract partial record IntraPositionProcessingStatus6Choice_
    {
    }
}
