// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus26Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus26Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionStatus26Choice.NoSpecifiedReason),
        nameof(RejectionStatus26Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionStatus26Choice.Reason),
        nameof(RejectionStatus26Choice.Reason)
    )]
    [IsoId("_8NoLU5NLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Status 26 Choice")]
    public abstract record RejectionStatus26Choice_ { }
}
