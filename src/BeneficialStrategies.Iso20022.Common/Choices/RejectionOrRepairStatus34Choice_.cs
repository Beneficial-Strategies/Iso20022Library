// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus34Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus34Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus34Choice.NoSpecifiedReason),
        nameof(RejectionOrRepairStatus34Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus34Choice.Reason),
        nameof(RejectionOrRepairStatus34Choice.Reason)
    )]
    [IsoId("_6GW9sZNLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Or Repair Status 34 Choice")]
    public abstract record RejectionOrRepairStatus34Choice_ { }
}
