// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(IntraPositionProcessingStatus9Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus9Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus9Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus9Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus9Choice.Proprietary))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus9Choice.Rejected),nameof(IntraPositionProcessingStatus9Choice.Rejected))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus9Choice.Repair),nameof(IntraPositionProcessingStatus9Choice.Repair))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus9Choice.Cancelled),nameof(IntraPositionProcessingStatus9Choice.Cancelled))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus9Choice.AcknowledgedAccepted),nameof(IntraPositionProcessingStatus9Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus9Choice.Proprietary),nameof(IntraPositionProcessingStatus9Choice.Proprietary))]
    [IsoId("_ZJraQStUEeyhipY4f42fZQ")]
    [DisplayName("Intra Position Processing Status 9 Choice")]
    public abstract partial record IntraPositionProcessingStatus9Choice_
    {
    }
}
