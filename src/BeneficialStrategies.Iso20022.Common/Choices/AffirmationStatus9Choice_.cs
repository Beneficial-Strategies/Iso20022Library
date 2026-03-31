// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the affirmation status.
    /// </summary>
    [KnownType(typeof(AffirmationStatus9Choice.Code))]
    [KnownType(typeof(AffirmationStatus9Choice.Proprietary))]
    [JsonDerivedType(typeof(AffirmationStatus9Choice.Code), nameof(AffirmationStatus9Choice.Code))]
    [JsonDerivedType(
        typeof(AffirmationStatus9Choice.Proprietary),
        nameof(AffirmationStatus9Choice.Proprietary)
    )]
    [IsoId("_5xm1DZNLEeWGlc8L7oPDIg")]
    [DisplayName("Affirmation Status 9 Choice")]
    public abstract record AffirmationStatus9Choice_ { }
}
