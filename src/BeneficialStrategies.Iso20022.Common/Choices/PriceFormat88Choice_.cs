// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format88Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat88Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat88Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat88Choice.PercentagePrice))]
    [JsonDerivedType(
        typeof(PriceFormat88Choice.AmountPrice),
        nameof(PriceFormat88Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat88Choice.NotSpecifiedPrice),
        nameof(PriceFormat88Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat88Choice.PercentagePrice),
        nameof(PriceFormat88Choice.PercentagePrice)
    )]
    [IsoId("_l6Uiz5t3Ee-wQIOX0djF2w")]
    [DisplayName("Price Format88Choice")]
    public abstract record PriceFormat88Choice_ { }
}
