// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the affirmation status.
    /// </summary>
    [KnownType(typeof(AffirmationReason2Choice.Reason))]
    [KnownType(typeof(AffirmationReason2Choice.NoSpecifiedReason))]
    [JsonDerivedType(
        typeof(AffirmationReason2Choice.Reason),
        nameof(AffirmationReason2Choice.Reason)
    )]
    [JsonDerivedType(
        typeof(AffirmationReason2Choice.NoSpecifiedReason),
        nameof(AffirmationReason2Choice.NoSpecifiedReason)
    )]
    [IsoId("_XzM-1wd3Ee2fOITqoTnSLQ")]
    [DisplayName("Affirmation Reason 2 Choice")]
    public abstract record AffirmationReason2Choice_ { }
}
