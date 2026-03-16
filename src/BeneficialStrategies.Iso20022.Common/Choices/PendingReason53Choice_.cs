// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason53Choice.Code))]
    [KnownType(typeof(PendingReason53Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason53Choice.Code), nameof(PendingReason53Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason53Choice.Proprietary),
        nameof(PendingReason53Choice.Proprietary)
    )]
    [IsoId("_kTWzM-XzEemEj48jhmlA0Q")]
    [DisplayName("Pending Reason 53 Choice")]
    public abstract record PendingReason53Choice_ { }
}
