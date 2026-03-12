// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus29Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus29Choice.Reason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus29Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus29Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus29Choice.Reason),nameof(RejectionOrRepairStatus29Choice.Reason))]
    [IsoId("_Jha0UTnuEeWfSKvvZlhRKg")]
    [DisplayName("Rejection Or Repair Status 29 Choice")]
    public abstract partial record RejectionOrRepairStatus29Choice_
    {
    }
}
