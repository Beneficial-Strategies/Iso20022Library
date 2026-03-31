// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason59Choice.Code))]
    [KnownType(typeof(PendingReason59Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason59Choice.Code), nameof(PendingReason59Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason59Choice.Proprietary),
        nameof(PendingReason59Choice.Proprietary)
    )]
    [IsoId("_glk6gxHpEeuE0Pnt-OcNOA")]
    [DisplayName("Pending Reason 59 Choice")]
    public abstract record PendingReason59Choice_ { }
}
