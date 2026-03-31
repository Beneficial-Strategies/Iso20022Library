// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RepairStatus13Choice.NoSpecifiedReason))]
    [KnownType(typeof(RepairStatus13Choice.Reason))]
    [JsonDerivedType(
        typeof(RepairStatus13Choice.NoSpecifiedReason),
        nameof(RepairStatus13Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RepairStatus13Choice.Reason), nameof(RepairStatus13Choice.Reason))]
    [IsoId("_0bSpwTqeEeWyoP0PbocV1Q")]
    [DisplayName("Repair Status 13 Choice")]
    public abstract record RepairStatus13Choice_ { }
}
