// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus31Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus31Choice.Reason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus31Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus31Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus31Choice.Reason),nameof(RejectionOrRepairStatus31Choice.Reason))]
    [IsoId("_nsTPwTq4EeWyoP0PbocV1Q")]
    [DisplayName("Rejection Or Repair Status 31 Choice")]
    public abstract partial record RejectionOrRepairStatus31Choice_
    {
    }
}
