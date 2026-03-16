// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(IntraPositionProcessingStatus1Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus1Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus1Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus1Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus1Choice.Rejected),
        nameof(IntraPositionProcessingStatus1Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus1Choice.Repair),
        nameof(IntraPositionProcessingStatus1Choice.Repair)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus1Choice.Cancelled),
        nameof(IntraPositionProcessingStatus1Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus1Choice.AcknowledgedAccepted),
        nameof(IntraPositionProcessingStatus1Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(IntraPositionProcessingStatus1Choice.Proprietary),
        nameof(IntraPositionProcessingStatus1Choice.Proprietary)
    )]
    [IsoId("_UW1baNp-Ed-ak6NoX_4Aeg_252032743")]
    [DisplayName("Intra Position Processing Status 1 Choice")]
    public abstract record IntraPositionProcessingStatus1Choice_ { }
}
