// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus45Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus45Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus45Choice.NoSpecifiedReason),
        nameof(RejectionOrRepairStatus45Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus45Choice.Reason),
        nameof(RejectionOrRepairStatus45Choice.Reason)
    )]
    [IsoId("_cdk0zTi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Or Repair Status 45 Choice")]
    public abstract record RejectionOrRepairStatus45Choice_ { }
}
