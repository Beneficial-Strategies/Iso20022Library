// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format91Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat91Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat91Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat91Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat91Choice.PercentagePrice))]
    [JsonDerivedType(
        typeof(PriceFormat91Choice.AmountPrice),
        nameof(PriceFormat91Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat91Choice.IndexPoints),
        nameof(PriceFormat91Choice.IndexPoints)
    )]
    [JsonDerivedType(
        typeof(PriceFormat91Choice.NotSpecifiedPrice),
        nameof(PriceFormat91Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat91Choice.PercentagePrice),
        nameof(PriceFormat91Choice.PercentagePrice)
    )]
    [IsoId("_nLgefZt3Ee-wQIOX0djF2w")]
    [DisplayName("Price Format91Choice")]
    public abstract record PriceFormat91Choice_ { }
}
