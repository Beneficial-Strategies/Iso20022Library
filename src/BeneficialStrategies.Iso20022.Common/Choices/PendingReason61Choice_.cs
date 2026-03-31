// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason61Choice.Code))]
    [KnownType(typeof(PendingReason61Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason61Choice.Code), nameof(PendingReason61Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason61Choice.Proprietary),
        nameof(PendingReason61Choice.Proprietary)
    )]
    [IsoId("_9FBNCR9QEeuFz_FaCzCLgQ")]
    [DisplayName("Pending Reason 61 Choice")]
    public abstract record PendingReason61Choice_ { }
}
