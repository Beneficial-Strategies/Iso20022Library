// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status for the affirmation.
    /// </summary>
    [KnownType(typeof(AffirmationStatus11Choice.Affirmed))]
    [KnownType(typeof(AffirmationStatus11Choice.Unaffirmed))]
    [KnownType(typeof(AffirmationStatus11Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(AffirmationStatus11Choice.Affirmed),nameof(AffirmationStatus11Choice.Affirmed))]
    [JsonDerivedType(typeof(AffirmationStatus11Choice.Unaffirmed),nameof(AffirmationStatus11Choice.Unaffirmed))]
    [JsonDerivedType(typeof(AffirmationStatus11Choice.ProprietaryStatus),nameof(AffirmationStatus11Choice.ProprietaryStatus))]
    [IsoId("_XiELhQd3Ee2fOITqoTnSLQ")]
    [DisplayName("Affirmation Status 11 Choice")]
    public abstract partial record AffirmationStatus11Choice_
    {
    }
}
