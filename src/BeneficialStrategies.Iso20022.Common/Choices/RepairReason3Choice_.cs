// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(RepairReason3Choice.Code))]
    [KnownType(typeof(RepairReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(RepairReason3Choice.Code),nameof(RepairReason3Choice.Code))]
    [JsonDerivedType(typeof(RepairReason3Choice.Proprietary),nameof(RepairReason3Choice.Proprietary))]
    [IsoId("_UYLfMNp-Ed-ak6NoX_4Aeg_-900951191")]
    [DisplayName("Repair Reason 3 Choice")]
    public abstract partial record RepairReason3Choice_
    {
    }
}
