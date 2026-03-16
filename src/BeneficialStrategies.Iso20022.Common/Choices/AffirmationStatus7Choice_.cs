// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the affirmation status.
    /// </summary>
    [KnownType(typeof(AffirmationStatus7Choice.Code))]
    [KnownType(typeof(AffirmationStatus7Choice.Proprietary))]
    [JsonDerivedType(typeof(AffirmationStatus7Choice.Code), nameof(AffirmationStatus7Choice.Code))]
    [JsonDerivedType(
        typeof(AffirmationStatus7Choice.Proprietary),
        nameof(AffirmationStatus7Choice.Proprietary)
    )]
    [IsoId("_A6DC4NokEeC60axPepSq7g_711252739")]
    [DisplayName("Affirmation Status 7 Choice")]
    public abstract record AffirmationStatus7Choice_ { }
}
