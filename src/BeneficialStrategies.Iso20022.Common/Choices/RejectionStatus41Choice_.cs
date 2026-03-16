// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus41Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus41Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionStatus41Choice.NoSpecifiedReason),
        nameof(RejectionStatus41Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionStatus41Choice.Reason),
        nameof(RejectionStatus41Choice.Reason)
    )]
    [IsoId("_dszBJji8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Status 41 Choice")]
    public abstract record RejectionStatus41Choice_ { }
}
