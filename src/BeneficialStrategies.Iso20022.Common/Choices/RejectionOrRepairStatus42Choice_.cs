// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus42Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus42Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus42Choice.NoSpecifiedReason),
        nameof(RejectionOrRepairStatus42Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus42Choice.Reason),
        nameof(RejectionOrRepairStatus42Choice.Reason)
    )]
    [IsoId("_mbmHCytVEeyhipY4f42fZQ")]
    [DisplayName("Rejection Or Repair Status 42 Choice")]
    public abstract record RejectionOrRepairStatus42Choice_ { }
}
