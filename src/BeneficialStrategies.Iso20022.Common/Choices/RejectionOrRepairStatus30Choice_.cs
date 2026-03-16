// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus30Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus30Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus30Choice.NoSpecifiedReason),
        nameof(RejectionOrRepairStatus30Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus30Choice.Reason),
        nameof(RejectionOrRepairStatus30Choice.Reason)
    )]
    [IsoId("_U2V2YTq4EeWyoP0PbocV1Q")]
    [DisplayName("Rejection Or Repair Status 30 Choice")]
    public abstract record RejectionOrRepairStatus30Choice_ { }
}
