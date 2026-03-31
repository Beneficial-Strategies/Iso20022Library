// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RepairStatus15Choice.NoSpecifiedReason))]
    [KnownType(typeof(RepairStatus15Choice.Reason))]
    [JsonDerivedType(
        typeof(RepairStatus15Choice.NoSpecifiedReason),
        nameof(RepairStatus15Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RepairStatus15Choice.Reason), nameof(RepairStatus15Choice.Reason))]
    [IsoId("_6BGCeZNLEeWGlc8L7oPDIg")]
    [DisplayName("Repair Status 15 Choice")]
    public abstract record RepairStatus15Choice_ { }
}
