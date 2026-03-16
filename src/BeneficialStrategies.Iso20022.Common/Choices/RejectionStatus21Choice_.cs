// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus21Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus21Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionStatus21Choice.NoSpecifiedReason),
        nameof(RejectionStatus21Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionStatus21Choice.Reason),
        nameof(RejectionStatus21Choice.Reason)
    )]
    [IsoId("_cU5kYT0CEeWjqIDN7tjEjQ")]
    [DisplayName("Rejection Status 21 Choice")]
    public abstract record RejectionStatus21Choice_ { }
}
