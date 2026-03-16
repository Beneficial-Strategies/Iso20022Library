// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason41Choice.Code))]
    [KnownType(typeof(PendingReason41Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason41Choice.Code), nameof(PendingReason41Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason41Choice.Proprietary),
        nameof(PendingReason41Choice.Proprietary)
    )]
    [IsoId("_6QB2R5NLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Reason 41 Choice")]
    public abstract record PendingReason41Choice_ { }
}
