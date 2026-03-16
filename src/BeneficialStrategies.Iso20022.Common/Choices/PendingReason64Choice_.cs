// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason64Choice.Code))]
    [KnownType(typeof(PendingReason64Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason64Choice.Code), nameof(PendingReason64Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason64Choice.Proprietary),
        nameof(PendingReason64Choice.Proprietary)
    )]
    [IsoId("_piJUPzi7Eeydid5dcNPKvg")]
    [DisplayName("Pending Reason 64 Choice")]
    public abstract record PendingReason64Choice_ { }
}
