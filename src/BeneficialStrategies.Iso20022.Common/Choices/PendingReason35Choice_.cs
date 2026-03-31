// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason35Choice.Code))]
    [KnownType(typeof(PendingReason35Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason35Choice.Code), nameof(PendingReason35Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason35Choice.Proprietary),
        nameof(PendingReason35Choice.Proprietary)
    )]
    [IsoId("_cgn4v5KQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Reason 35 Choice")]
    public abstract record PendingReason35Choice_ { }
}
