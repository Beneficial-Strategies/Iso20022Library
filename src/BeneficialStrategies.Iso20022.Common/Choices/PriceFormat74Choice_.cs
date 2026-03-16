// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format74Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat74Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat74Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat74Choice.PercentagePrice))]
    [JsonDerivedType(
        typeof(PriceFormat74Choice.AmountPrice),
        nameof(PriceFormat74Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat74Choice.NotSpecifiedPrice),
        nameof(PriceFormat74Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat74Choice.PercentagePrice),
        nameof(PriceFormat74Choice.PercentagePrice)
    )]
    [IsoId("_C1fqMYV6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Price Format74Choice")]
    public abstract record PriceFormat74Choice_ { }
}
