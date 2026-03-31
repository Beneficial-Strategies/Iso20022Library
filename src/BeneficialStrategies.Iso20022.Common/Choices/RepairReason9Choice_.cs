// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(RepairReason9Choice.Code))]
    [KnownType(typeof(RepairReason9Choice.Proprietary))]
    [JsonDerivedType(typeof(RepairReason9Choice.Code), nameof(RepairReason9Choice.Code))]
    [JsonDerivedType(
        typeof(RepairReason9Choice.Proprietary),
        nameof(RepairReason9Choice.Proprietary)
    )]
    [IsoId("_A5mW8NokEeC60axPepSq7g_-1465147117")]
    [DisplayName("Repair Reason 9 Choice")]
    public abstract record RepairReason9Choice_ { }
}
