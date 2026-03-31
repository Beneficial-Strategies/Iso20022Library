// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(RepairReason10Choice.Code))]
    [KnownType(typeof(RepairReason10Choice.Proprietary))]
    [JsonDerivedType(typeof(RepairReason10Choice.Code), nameof(RepairReason10Choice.Code))]
    [JsonDerivedType(
        typeof(RepairReason10Choice.Proprietary),
        nameof(RepairReason10Choice.Proprietary)
    )]
    [IsoId("_z7vnATqeEeWyoP0PbocV1Q")]
    [DisplayName("Repair Reason 10 Choice")]
    public abstract record RepairReason10Choice_ { }
}
