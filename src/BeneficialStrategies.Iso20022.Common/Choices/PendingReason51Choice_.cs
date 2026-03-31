// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason51Choice.Code))]
    [KnownType(typeof(PendingReason51Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason51Choice.Code), nameof(PendingReason51Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason51Choice.Proprietary),
        nameof(PendingReason51Choice.Proprietary)
    )]
    [IsoId("_e4Mr0bLLEemDyeh7tbvg1w")]
    [DisplayName("Pending Reason 51 Choice")]
    public abstract record PendingReason51Choice_ { }
}
