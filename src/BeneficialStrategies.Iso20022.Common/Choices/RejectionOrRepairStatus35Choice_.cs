// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus35Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus35Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus35Choice.NoSpecifiedReason),
        nameof(RejectionOrRepairStatus35Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus35Choice.Reason),
        nameof(RejectionOrRepairStatus35Choice.Reason)
    )]
    [IsoId("_6QESj5NLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Or Repair Status 35 Choice")]
    public abstract record RejectionOrRepairStatus35Choice_ { }
}
