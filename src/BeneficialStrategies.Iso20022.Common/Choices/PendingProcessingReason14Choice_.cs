// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending processing reason.
    /// </summary>
    [KnownType(typeof(PendingProcessingReason14Choice.Code))]
    [KnownType(typeof(PendingProcessingReason14Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PendingProcessingReason14Choice.Code),
        nameof(PendingProcessingReason14Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PendingProcessingReason14Choice.Proprietary),
        nameof(PendingProcessingReason14Choice.Proprietary)
    )]
    [IsoId("_6P-zN5NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Processing Reason 14 Choice")]
    public abstract record PendingProcessingReason14Choice_ { }
}
