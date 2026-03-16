// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus32Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus32Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus32Choice.NoSpecifiedReason),
        nameof(RejectionOrRepairStatus32Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus32Choice.Reason),
        nameof(RejectionOrRepairStatus32Choice.Reason)
    )]
    [IsoId("_yrFlMTs_EeWRTLSN0i0tng")]
    [DisplayName("Rejection Or Repair Status 32 Choice")]
    public abstract record RejectionOrRepairStatus32Choice_ { }
}
