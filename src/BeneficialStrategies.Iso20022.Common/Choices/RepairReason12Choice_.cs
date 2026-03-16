// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(RepairReason12Choice.Code))]
    [KnownType(typeof(RepairReason12Choice.Proprietary))]
    [JsonDerivedType(typeof(RepairReason12Choice.Code), nameof(RepairReason12Choice.Code))]
    [JsonDerivedType(
        typeof(RepairReason12Choice.Proprietary),
        nameof(RepairReason12Choice.Proprietary)
    )]
    [IsoId("_ja_PsTw5EeW3QqUkIQtIUA")]
    [DisplayName("Repair Reason 12 Choice")]
    public abstract record RepairReason12Choice_ { }
}
