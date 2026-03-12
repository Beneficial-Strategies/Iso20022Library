// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(RepairReason19Choice.Code))]
    [KnownType(typeof(RepairReason19Choice.Proprietary))]
    [JsonDerivedType(typeof(RepairReason19Choice.Code),nameof(RepairReason19Choice.Code))]
    [JsonDerivedType(typeof(RepairReason19Choice.Proprietary),nameof(RepairReason19Choice.Proprietary))]
    [IsoId("_g_M0Wwd3Ee2fOITqoTnSLQ")]
    [DisplayName("Repair Reason 19 Choice")]
    public abstract partial record RepairReason19Choice_
    {
    }
}
