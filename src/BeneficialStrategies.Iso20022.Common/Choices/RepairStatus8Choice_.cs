// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RepairStatus8Choice.NoSpecifiedReason))]
    [KnownType(typeof(RepairStatus8Choice.Reason))]
    [JsonDerivedType(
        typeof(RepairStatus8Choice.NoSpecifiedReason),
        nameof(RepairStatus8Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RepairStatus8Choice.Reason), nameof(RepairStatus8Choice.Reason))]
    [IsoId("_0ka00AlIEeGATtfOBToyew_412690380")]
    [DisplayName("Repair Status 8 Choice")]
    public abstract record RepairStatus8Choice_ { }
}
