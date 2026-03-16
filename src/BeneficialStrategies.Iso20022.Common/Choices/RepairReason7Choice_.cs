// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(RepairReason7Choice.Code))]
    [KnownType(typeof(RepairReason7Choice.Proprietary))]
    [JsonDerivedType(typeof(RepairReason7Choice.Code), nameof(RepairReason7Choice.Code))]
    [JsonDerivedType(
        typeof(RepairReason7Choice.Proprietary),
        nameof(RepairReason7Choice.Proprietary)
    )]
    [IsoId("_zFHJdj9qEeCY7potQsO_IA")]
    [DisplayName("Repair Reason 7 Choice")]
    public abstract record RepairReason7Choice_ { }
}
