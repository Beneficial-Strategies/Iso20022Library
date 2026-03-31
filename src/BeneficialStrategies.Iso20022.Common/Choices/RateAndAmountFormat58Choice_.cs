// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format58Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat58Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat58Choice.IndexPoints))]
    [KnownType(typeof(RateAndAmountFormat58Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat58Choice.Rate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat58Choice.Amount),
        nameof(RateAndAmountFormat58Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat58Choice.IndexPoints),
        nameof(RateAndAmountFormat58Choice.IndexPoints)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat58Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat58Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat58Choice.Rate),
        nameof(RateAndAmountFormat58Choice.Rate)
    )]
    [IsoId("_wPdjMYV5Ee-oeNhl-Tk6YQ")]
    [DisplayName("Rate And Amount Format58Choice")]
    public abstract record RateAndAmountFormat58Choice_ { }
}
