// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format55Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat55Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat55Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat55Choice.RateTypeAndRate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat55Choice.Amount),
        nameof(RateAndAmountFormat55Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat55Choice.Rate),
        nameof(RateAndAmountFormat55Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat55Choice.RateTypeAndRate),
        nameof(RateAndAmountFormat55Choice.RateTypeAndRate)
    )]
    [IsoId("_2i6T84V4Ee-oeNhl-Tk6YQ")]
    [DisplayName("Rate And Amount Format55Choice")]
    public abstract record RateAndAmountFormat55Choice_ { }
}
