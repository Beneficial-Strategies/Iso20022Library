// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus25Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus25Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus25Choice.NoSpecifiedReason),
        nameof(RejectionOrRepairStatus25Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus25Choice.Reason),
        nameof(RejectionOrRepairStatus25Choice.Reason)
    )]
    [IsoId("__kUpc0NHEeGHJ_bHJRPaIQ_1391155212")]
    [DisplayName("Rejection Or Repair Status 25 Choice")]
    public abstract record RejectionOrRepairStatus25Choice_ { }
}
