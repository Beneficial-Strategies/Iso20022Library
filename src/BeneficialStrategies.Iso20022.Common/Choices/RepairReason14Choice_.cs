// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(RepairReason14Choice.Code))]
    [KnownType(typeof(RepairReason14Choice.Proprietary))]
    [JsonDerivedType(typeof(RepairReason14Choice.Code), nameof(RepairReason14Choice.Code))]
    [JsonDerivedType(
        typeof(RepairReason14Choice.Proprietary),
        nameof(RepairReason14Choice.Proprietary)
    )]
    [IsoId("_6P_aDZNLEeWGlc8L7oPDIg")]
    [DisplayName("Repair Reason 14 Choice")]
    public abstract record RepairReason14Choice_ { }
}
