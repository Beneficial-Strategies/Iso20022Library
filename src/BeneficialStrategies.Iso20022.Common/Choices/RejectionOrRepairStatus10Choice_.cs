// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus10Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus10Choice.Reason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus10Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus10Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus10Choice.Reason),nameof(RejectionOrRepairStatus10Choice.Reason))]
    [IsoId("_au8iseZgEd-q8fx_Zl_34A")]
    [DisplayName("Rejection Or Repair Status 10 Choice")]
    public abstract partial record RejectionOrRepairStatus10Choice_
    {
    }
}
