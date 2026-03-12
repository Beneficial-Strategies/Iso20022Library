// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(RepairReason13Choice.Code))]
    [KnownType(typeof(RepairReason13Choice.Proprietary))]
    [JsonDerivedType(typeof(RepairReason13Choice.Code),nameof(RepairReason13Choice.Code))]
    [JsonDerivedType(typeof(RepairReason13Choice.Proprietary),nameof(RepairReason13Choice.Proprietary))]
    [IsoId("_6BHQY5NLEeWGlc8L7oPDIg")]
    [DisplayName("Repair Reason 13 Choice")]
    public abstract partial record RepairReason13Choice_
    {
    }
}
