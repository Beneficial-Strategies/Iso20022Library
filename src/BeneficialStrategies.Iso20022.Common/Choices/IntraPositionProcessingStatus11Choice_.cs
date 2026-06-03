// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for the processing status.</summary>
    [KnownType(typeof(IntraPositionProcessingStatus11Choice.Rejected))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus11Choice.Rejected), nameof(IntraPositionProcessingStatus11Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus11Choice.Repair))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus11Choice.Repair), nameof(IntraPositionProcessingStatus11Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus11Choice.Cancelled))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus11Choice.Cancelled), nameof(IntraPositionProcessingStatus11Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus11Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus11Choice.AcknowledgedAccepted), nameof(IntraPositionProcessingStatus11Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus11Choice.Proprietary))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus11Choice.Proprietary), nameof(IntraPositionProcessingStatus11Choice.Proprietary))]
    [IsoId("999c835c-c42b-4914-995f-f4b19e8f80af")]
    [DisplayName("Intra Position Processing Status 11 Choice")]
    public abstract record IntraPositionProcessingStatus11Choice_ { }
}
