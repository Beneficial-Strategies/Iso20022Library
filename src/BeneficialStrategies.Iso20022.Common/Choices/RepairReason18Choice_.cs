// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(RepairReason18Choice.Code))]
    [KnownType(typeof(RepairReason18Choice.Proprietary))]
    [JsonDerivedType(typeof(RepairReason18Choice.Code),nameof(RepairReason18Choice.Code))]
    [JsonDerivedType(typeof(RepairReason18Choice.Proprietary),nameof(RepairReason18Choice.Proprietary))]
    [IsoId("_8QddO5NLEeWGlc8L7oPDIg")]
    [DisplayName("Repair Reason 18 Choice")]
    public abstract partial record RepairReason18Choice_
    {
    }
}
