// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status for the affirmation.
    /// </summary>
    [KnownType(typeof(AffirmationStatus6Choice.Affirmed))]
    [KnownType(typeof(AffirmationStatus6Choice.Unaffirmed))]
    [KnownType(typeof(AffirmationStatus6Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(AffirmationStatus6Choice.Affirmed),nameof(AffirmationStatus6Choice.Affirmed))]
    [JsonDerivedType(typeof(AffirmationStatus6Choice.Unaffirmed),nameof(AffirmationStatus6Choice.Unaffirmed))]
    [JsonDerivedType(typeof(AffirmationStatus6Choice.ProprietaryStatus),nameof(AffirmationStatus6Choice.ProprietaryStatus))]
    [IsoId("_A55R5NokEeC60axPepSq7g_-1061221633")]
    [DisplayName("Affirmation Status 6 Choice")]
    public abstract partial record AffirmationStatus6Choice_
    {
    }
}
