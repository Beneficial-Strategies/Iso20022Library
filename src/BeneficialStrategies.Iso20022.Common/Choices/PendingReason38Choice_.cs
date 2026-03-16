// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason38Choice.Code))]
    [KnownType(typeof(PendingReason38Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason38Choice.Code), nameof(PendingReason38Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason38Choice.Proprietary),
        nameof(PendingReason38Choice.Proprietary)
    )]
    [IsoId("_6BKT1ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Reason 38 Choice")]
    public abstract record PendingReason38Choice_ { }
}
