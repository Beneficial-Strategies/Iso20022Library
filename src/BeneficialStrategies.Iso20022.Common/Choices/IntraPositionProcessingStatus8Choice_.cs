// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(IntraPositionProcessingStatus8Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus8Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus8Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus8Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus8Choice.Proprietary))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus8Choice.Rejected),nameof(IntraPositionProcessingStatus8Choice.Rejected))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus8Choice.Repair),nameof(IntraPositionProcessingStatus8Choice.Repair))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus8Choice.Cancelled),nameof(IntraPositionProcessingStatus8Choice.Cancelled))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus8Choice.AcknowledgedAccepted),nameof(IntraPositionProcessingStatus8Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(IntraPositionProcessingStatus8Choice.Proprietary),nameof(IntraPositionProcessingStatus8Choice.Proprietary))]
    [IsoId("_65NaH_fUEeiNZp_PtLohLw")]
    [DisplayName("Intra Position Processing Status 8 Choice")]
    public abstract partial record IntraPositionProcessingStatus8Choice_
    {
    }
}
