// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format93Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat93Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat93Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat93Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat93Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat93Choice.AmountPrice),nameof(PriceFormat93Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat93Choice.IndexPoints),nameof(PriceFormat93Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat93Choice.NotSpecifiedPrice),nameof(PriceFormat93Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat93Choice.PercentagePrice),nameof(PriceFormat93Choice.PercentagePrice))]
    [IsoId("_nLjhhZt3Ee-wQIOX0djF2w")]
    [DisplayName("Price Format93Choice")]
    public abstract partial record PriceFormat93Choice_
    {
    }
}
