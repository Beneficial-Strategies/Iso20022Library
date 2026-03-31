// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus46Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus46Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus46Choice.NoSpecifiedReason),
        nameof(RejectionOrRepairStatus46Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus46Choice.Reason),
        nameof(RejectionOrRepairStatus46Choice.Reason)
    )]
    [IsoId("_diXTezi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Or Repair Status 46 Choice")]
    public abstract record RejectionOrRepairStatus46Choice_ { }
}
