// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RepairStatus12Choice.NoSpecifiedReason))]
    [KnownType(typeof(RepairStatus12Choice.Reason))]
    [JsonDerivedType(
        typeof(RepairStatus12Choice.NoSpecifiedReason),
        nameof(RepairStatus12Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RepairStatus12Choice.Reason), nameof(RepairStatus12Choice.Reason))]
    [IsoId("_y8E5sTqeEeWyoP0PbocV1Q")]
    [DisplayName("Repair Status 12 Choice")]
    public abstract record RepairStatus12Choice_ { }
}
