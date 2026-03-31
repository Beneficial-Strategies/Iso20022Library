// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Reason66Choice.
    /// </summary>
    [KnownType(typeof(PendingReason66Choice.Code))]
    [KnownType(typeof(PendingReason66Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason66Choice.Code), nameof(PendingReason66Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason66Choice.Proprietary),
        nameof(PendingReason66Choice.Proprietary)
    )]
    [IsoId("_QGnc01x2Ee6fgZt44_IqFA")]
    [DisplayName("Pending Reason66Choice")]
    public abstract record PendingReason66Choice_ { }
}
