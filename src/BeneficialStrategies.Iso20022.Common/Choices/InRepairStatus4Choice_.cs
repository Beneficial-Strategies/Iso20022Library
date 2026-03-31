// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the in repair status.
    /// </summary>
    [KnownType(typeof(InRepairStatus4Choice.Reason))]
    [KnownType(typeof(InRepairStatus4Choice.DataSourceScheme))]
    [KnownType(typeof(InRepairStatus4Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(InRepairStatus4Choice.Reason), nameof(InRepairStatus4Choice.Reason))]
    [JsonDerivedType(
        typeof(InRepairStatus4Choice.DataSourceScheme),
        nameof(InRepairStatus4Choice.DataSourceScheme)
    )]
    [JsonDerivedType(
        typeof(InRepairStatus4Choice.NoSpecifiedReason),
        nameof(InRepairStatus4Choice.NoSpecifiedReason)
    )]
    [IsoId("_xydlISY4EeW_ZNn8gbfY7Q")]
    [DisplayName("In Repair Status 4 Choice")]
    public abstract record InRepairStatus4Choice_ { }
}
