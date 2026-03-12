// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repair reason.
    /// </summary>
    [KnownType(typeof(RepairReason1Choice.Code))]
    [KnownType(typeof(RepairReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(RepairReason1Choice.Code),nameof(RepairReason1Choice.Code))]
    [JsonDerivedType(typeof(RepairReason1Choice.Proprietary),nameof(RepairReason1Choice.Proprietary))]
    [IsoId("_UYoLJdp-Ed-ak6NoX_4Aeg_-1725604264")]
    [DisplayName("Repair Reason 1 Choice")]
    public abstract partial record RepairReason1Choice_
    {
    }
}
