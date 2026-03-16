// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RepairStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(RepairStatus1Choice.Reason))]
    [JsonDerivedType(
        typeof(RepairStatus1Choice.NoSpecifiedReason),
        nameof(RepairStatus1Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RepairStatus1Choice.Reason), nameof(RepairStatus1Choice.Reason))]
    [IsoId("_UYxVEtp-Ed-ak6NoX_4Aeg_284811139")]
    [DisplayName("Repair Status 1 Choice")]
    public abstract record RepairStatus1Choice_ { }
}
