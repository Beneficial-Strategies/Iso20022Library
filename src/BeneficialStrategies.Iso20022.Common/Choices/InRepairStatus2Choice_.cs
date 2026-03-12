// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status is in repair status.
    /// </summary>
    [KnownType(typeof(InRepairStatus2Choice.Reason))]
    [KnownType(typeof(InRepairStatus2Choice.DataSourceScheme))]
    [KnownType(typeof(InRepairStatus2Choice.NoReason))]
    [JsonDerivedType(typeof(InRepairStatus2Choice.Reason),nameof(InRepairStatus2Choice.Reason))]
    [JsonDerivedType(typeof(InRepairStatus2Choice.DataSourceScheme),nameof(InRepairStatus2Choice.DataSourceScheme))]
    [JsonDerivedType(typeof(InRepairStatus2Choice.NoReason),nameof(InRepairStatus2Choice.NoReason))]
    [IsoId("_Ut7sw9p-Ed-ak6NoX_4Aeg_1209831278")]
    [DisplayName("In Repair Status 2 Choice")]
    public abstract partial record InRepairStatus2Choice_
    {
    }
}
