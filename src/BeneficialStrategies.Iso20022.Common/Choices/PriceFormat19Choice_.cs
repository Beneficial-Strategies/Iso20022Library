// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price.
    /// </summary>
    [KnownType(typeof(PriceFormat19Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat19Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat19Choice.NotSpecifiedPrice))]
    [JsonDerivedType(
        typeof(PriceFormat19Choice.PercentagePrice),
        nameof(PriceFormat19Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat19Choice.AmountPrice),
        nameof(PriceFormat19Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat19Choice.NotSpecifiedPrice),
        nameof(PriceFormat19Choice.NotSpecifiedPrice)
    )]
    [IsoId("_oc2EQeEJEd-udr336SN7mQ")]
    [DisplayName("Price Format 19 Choice")]
    public abstract record PriceFormat19Choice_ { }
}
