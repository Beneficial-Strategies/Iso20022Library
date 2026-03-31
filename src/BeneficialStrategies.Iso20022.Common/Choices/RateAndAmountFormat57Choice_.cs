// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format57Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat57Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat57Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat57Choice.Rate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat57Choice.Amount),
        nameof(RateAndAmountFormat57Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat57Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat57Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat57Choice.Rate),
        nameof(RateAndAmountFormat57Choice.Rate)
    )]
    [IsoId("_gDY9MYV5Ee-oeNhl-Tk6YQ")]
    [DisplayName("Rate And Amount Format57Choice")]
    public abstract record RateAndAmountFormat57Choice_ { }
}
