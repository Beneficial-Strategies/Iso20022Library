// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format82Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat82Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat82Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat82Choice.PercentagePrice))]
    [JsonDerivedType(
        typeof(PriceFormat82Choice.AmountPrice),
        nameof(PriceFormat82Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat82Choice.NotSpecifiedPrice),
        nameof(PriceFormat82Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat82Choice.PercentagePrice),
        nameof(PriceFormat82Choice.PercentagePrice)
    )]
    [IsoId("_j2Fan5t3Ee-wQIOX0djF2w")]
    [DisplayName("Price Format82Choice")]
    public abstract record PriceFormat82Choice_ { }
}
