// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason28Choice.Code))]
    [KnownType(typeof(PendingReason28Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason28Choice.Code), nameof(PendingReason28Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason28Choice.Proprietary),
        nameof(PendingReason28Choice.Proprietary)
    )]
    [IsoId("_GnAMQTqfEeWyoP0PbocV1Q")]
    [DisplayName("Pending Reason 28 Choice")]
    public abstract record PendingReason28Choice_ { }
}
