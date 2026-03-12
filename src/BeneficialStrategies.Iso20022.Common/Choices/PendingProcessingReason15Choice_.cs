// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending processing reason.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason15Choice.Code))]
    [KnownType(typeof(PendingProcessingReason15Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingProcessingReason15Choice.Code),nameof(PendingProcessingReason15Choice.Code))]
    [JsonDerivedType(typeof(PendingProcessingReason15Choice.Proprietary),nameof(PendingProcessingReason15Choice.Proprietary))]
    [IsoId("_6QCdyZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Processing Reason 15 Choice")]
    public abstract partial record PendingProcessingReason15Choice_
    {
    }
}
