// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending processing reason.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason13Choice.Code))]
    [KnownType(typeof(PendingProcessingReason13Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PendingProcessingReason13Choice.Code),
        nameof(PendingProcessingReason13Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingReason13Choice.Proprietary),
        nameof(PendingProcessingReason13Choice.Proprietary)
    )]
    [IsoId("_6BFbuZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Processing Reason 13 Choice")]
    public abstract record PendingProcessingReason13Choice_ { }
}
