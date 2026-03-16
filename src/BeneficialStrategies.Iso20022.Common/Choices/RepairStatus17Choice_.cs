// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RepairStatus17Choice.NoSpecifiedReason))]
    [KnownType(typeof(RepairStatus17Choice.Reason))]
    [JsonDerivedType(
        typeof(RepairStatus17Choice.NoSpecifiedReason),
        nameof(RepairStatus17Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RepairStatus17Choice.Reason), nameof(RepairStatus17Choice.Reason))]
    [IsoId("_6QDEzZNLEeWGlc8L7oPDIg")]
    [DisplayName("Repair Status 17 Choice")]
    public abstract record RepairStatus17Choice_ { }
}
