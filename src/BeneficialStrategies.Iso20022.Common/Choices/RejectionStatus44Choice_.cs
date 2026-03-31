// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus44Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus44Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionStatus44Choice.NoSpecifiedReason),
        nameof(RejectionStatus44Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionStatus44Choice.Reason),
        nameof(RejectionStatus44Choice.Reason)
    )]
    [IsoId("_f9795zi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Status 44 Choice")]
    public abstract record RejectionStatus44Choice_ { }
}
