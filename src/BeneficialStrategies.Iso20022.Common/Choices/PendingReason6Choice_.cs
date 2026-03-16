// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason6Choice.Code))]
    [KnownType(typeof(PendingReason6Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason6Choice.Code), nameof(PendingReason6Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason6Choice.Proprietary),
        nameof(PendingReason6Choice.Proprietary)
    )]
    [IsoId("_QyGwaNp-Ed-ak6NoX_4Aeg_1186273655")]
    [DisplayName("Pending Reason 6 Choice")]
    public abstract record PendingReason6Choice_ { }
}
