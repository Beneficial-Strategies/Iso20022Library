// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus22Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus22Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionStatus22Choice.NoSpecifiedReason),
        nameof(RejectionStatus22Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionStatus22Choice.Reason),
        nameof(RejectionStatus22Choice.Reason)
    )]
    [IsoId("_6BGCQ5NLEeWGlc8L7oPDIg")]
    [DisplayName("Rejection Status 22 Choice")]
    public abstract record RejectionStatus22Choice_ { }
}
