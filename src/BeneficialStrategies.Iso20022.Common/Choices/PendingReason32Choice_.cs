// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason32Choice.Code))]
    [KnownType(typeof(PendingReason32Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason32Choice.Code), nameof(PendingReason32Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason32Choice.Proprietary),
        nameof(PendingReason32Choice.Proprietary)
    )]
    [IsoId("_te0zE0GSEeWqy4niLuXETA")]
    [DisplayName("Pending Reason 32 Choice")]
    public abstract record PendingReason32Choice_ { }
}
