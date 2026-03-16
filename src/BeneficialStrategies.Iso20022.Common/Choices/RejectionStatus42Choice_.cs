// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus42Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus42Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionStatus42Choice.NoSpecifiedReason),
        nameof(RejectionStatus42Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionStatus42Choice.Reason),
        nameof(RejectionStatus42Choice.Reason)
    )]
    [IsoId("_ds03JTi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Status 42 Choice")]
    public abstract record RejectionStatus42Choice_ { }
}
