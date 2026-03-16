// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RepairStatus6Choice.NoSpecifiedReason))]
    [KnownType(typeof(RepairStatus6Choice.Reason))]
    [JsonDerivedType(
        typeof(RepairStatus6Choice.NoSpecifiedReason),
        nameof(RepairStatus6Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RepairStatus6Choice.Reason), nameof(RepairStatus6Choice.Reason))]
    [IsoId("_Vn3Okf7rEeCvPoRGOxRobQ")]
    [DisplayName("Repair Status 6 Choice")]
    public abstract record RepairStatus6Choice_ { }
}
