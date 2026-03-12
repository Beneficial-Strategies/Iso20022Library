// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason24Choice.Code))]
    [KnownType(typeof(PendingReason24Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason24Choice.Code),nameof(PendingReason24Choice.Code))]
    [JsonDerivedType(typeof(PendingReason24Choice.Proprietary),nameof(PendingReason24Choice.Proprietary))]
    [IsoId("_U0rZk1hbEeSewsfsZR0hxA")]
    [DisplayName("Pending Reason 24 Choice")]
    public abstract partial record PendingReason24Choice_
    {
    }
}
