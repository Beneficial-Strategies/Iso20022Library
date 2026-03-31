// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus40Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus40Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectionStatus40Choice.NoSpecifiedReason),
        nameof(RejectionStatus40Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(RejectionStatus40Choice.Reason),
        nameof(RejectionStatus40Choice.Reason)
    )]
    [IsoId("_ddA4kTi8Eeydid5dcNPKvg")]
    [DisplayName("Rejection Status 40 Choice")]
    public abstract record RejectionStatus40Choice_ { }
}
