// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(RepairReason11Choice.Code))]
    [KnownType(typeof(RepairReason11Choice.Proprietary))]
    [JsonDerivedType(typeof(RepairReason11Choice.Code), nameof(RepairReason11Choice.Code))]
    [JsonDerivedType(
        typeof(RepairReason11Choice.Proprietary),
        nameof(RepairReason11Choice.Proprietary)
    )]
    [IsoId("_KxvzsTqyEeWyoP0PbocV1Q")]
    [DisplayName("Repair Reason 11 Choice")]
    public abstract record RepairReason11Choice_ { }
}
