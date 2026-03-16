// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus33Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus33Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus33Choice.NoSpecifiedReason),
        nameof(RejectionOrRepairStatus33Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionOrRepairStatus33Choice.Reason),
        nameof(RejectionOrRepairStatus33Choice.Reason)
    )]
    [IsoId("_5SFAb5NLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Or Repair Status 33 Choice")]
    public abstract record RejectionOrRepairStatus33Choice_ { }
}
