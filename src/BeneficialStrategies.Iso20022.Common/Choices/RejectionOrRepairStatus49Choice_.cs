// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus49Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus49Choice.Reason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus49Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus49Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus49Choice.Reason),nameof(RejectionOrRepairStatus49Choice.Reason))]
    [IsoId("_gBIbLTi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Or Repair Status 49 Choice")]
    public abstract partial record RejectionOrRepairStatus49Choice_
    {
    }
}
