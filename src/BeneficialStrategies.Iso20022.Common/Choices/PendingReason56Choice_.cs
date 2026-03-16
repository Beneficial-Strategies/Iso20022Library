// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason56Choice.Code))]
    [KnownType(typeof(PendingReason56Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason56Choice.Code), nameof(PendingReason56Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason56Choice.Proprietary),
        nameof(PendingReason56Choice.Proprietary)
    )]
    [IsoId("_Pl8gHwVSEeqjd8n6wD9JVw")]
    [DisplayName("Pending Reason 56 Choice")]
    public abstract record PendingReason56Choice_ { }
}
