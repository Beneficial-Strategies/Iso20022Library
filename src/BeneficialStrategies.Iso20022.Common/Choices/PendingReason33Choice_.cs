// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason33Choice.Code))]
    [KnownType(typeof(PendingReason33Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason33Choice.Code), nameof(PendingReason33Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason33Choice.Proprietary),
        nameof(PendingReason33Choice.Proprietary)
    )]
    [IsoId("_CIi-M0GVEeWqy4niLuXETA")]
    [DisplayName("Pending Reason 33 Choice")]
    public abstract record PendingReason33Choice_ { }
}
