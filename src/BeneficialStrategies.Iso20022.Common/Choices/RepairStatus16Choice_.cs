// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RepairStatus16Choice.NoSpecifiedReason))]
    [KnownType(typeof(RepairStatus16Choice.Reason))]
    [JsonDerivedType(typeof(RepairStatus16Choice.NoSpecifiedReason),nameof(RepairStatus16Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RepairStatus16Choice.Reason),nameof(RepairStatus16Choice.Reason))]
    [IsoId("_6P_Z45NLEeWGlc8L7oPDIg")]
    [DisplayName("Repair Status 16 Choice")]
    public abstract partial record RepairStatus16Choice_
    {
    }
}
