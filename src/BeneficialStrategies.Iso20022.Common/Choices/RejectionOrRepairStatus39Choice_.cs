// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus39Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus39Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus39Choice.NoSpecifiedReason),
        nameof(RejectionOrRepairStatus39Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus39Choice.Reason),
        nameof(RejectionOrRepairStatus39Choice.Reason)
    )]
    [IsoId("_b4JB8eF8EeWCAvUNsZ5u6g")]
    [DisplayName("Rejection Or Repair Status 39 Choice")]
    public abstract record RejectionOrRepairStatus39Choice_ { }
}
