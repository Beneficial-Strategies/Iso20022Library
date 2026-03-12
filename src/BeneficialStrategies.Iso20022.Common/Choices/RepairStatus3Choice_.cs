// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RepairStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(RepairStatus3Choice.Reason))]
    [JsonDerivedType(typeof(RepairStatus3Choice.NoSpecifiedReason),nameof(RepairStatus3Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RepairStatus3Choice.Reason),nameof(RepairStatus3Choice.Reason))]
    [IsoId("_UVpIltp-Ed-ak6NoX_4Aeg_1319762643")]
    [DisplayName("Repair Status 3 Choice")]
    public abstract partial record RepairStatus3Choice_
    {
    }
}
