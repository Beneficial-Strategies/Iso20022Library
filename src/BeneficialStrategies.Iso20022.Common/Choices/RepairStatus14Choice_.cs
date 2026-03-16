// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RepairStatus14Choice.NoSpecifiedReason))]
    [KnownType(typeof(RepairStatus14Choice.Reason))]
    [JsonDerivedType(
        typeof(RepairStatus14Choice.NoSpecifiedReason),
        nameof(RepairStatus14Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RepairStatus14Choice.Reason), nameof(RepairStatus14Choice.Reason))]
    [IsoId("_iYMV4Tw5EeW3QqUkIQtIUA")]
    [DisplayName("Repair Status 14 Choice")]
    public abstract record RepairStatus14Choice_ { }
}
