// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RepairStatus5Choice.NoSpecifiedReason))]
    [KnownType(typeof(RepairStatus5Choice.Reason))]
    [JsonDerivedType(
        typeof(RepairStatus5Choice.NoSpecifiedReason),
        nameof(RepairStatus5Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RepairStatus5Choice.Reason), nameof(RepairStatus5Choice.Reason))]
    [IsoId("_3er0gf7qEeCvPoRGOxRobQ")]
    [DisplayName("Repair Status 5 Choice")]
    public abstract record RepairStatus5Choice_ { }
}
