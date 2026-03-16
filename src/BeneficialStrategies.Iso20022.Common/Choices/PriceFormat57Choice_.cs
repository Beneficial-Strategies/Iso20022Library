// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price.
    /// </summary>
    [KnownType(typeof(PriceFormat57Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat57Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat57Choice.NotSpecifiedPrice))]
    [JsonDerivedType(
        typeof(PriceFormat57Choice.PercentagePrice),
        nameof(PriceFormat57Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat57Choice.AmountPrice),
        nameof(PriceFormat57Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat57Choice.NotSpecifiedPrice),
        nameof(PriceFormat57Choice.NotSpecifiedPrice)
    )]
    [IsoId("_ctfPh5KQEeWHWpTQn1FFVg")]
    [DisplayName("Price Format 57 Choice")]
    public abstract record PriceFormat57Choice_ { }
}
