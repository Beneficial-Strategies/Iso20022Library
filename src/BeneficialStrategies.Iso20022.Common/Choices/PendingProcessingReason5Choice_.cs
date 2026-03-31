// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending processing reason.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason5Choice.Code))]
    [KnownType(typeof(PendingProcessingReason5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PendingProcessingReason5Choice.Code),
        nameof(PendingProcessingReason5Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingReason5Choice.Proprietary),
        nameof(PendingProcessingReason5Choice.Proprietary)
    )]
    [IsoId("_0jExAAlIEeGATtfOBToyew_-1834452611")]
    [DisplayName("Pending Processing Reason 5 Choice")]
    public abstract record PendingProcessingReason5Choice_ { }
}
