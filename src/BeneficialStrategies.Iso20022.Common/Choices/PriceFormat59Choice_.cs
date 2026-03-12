// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or index points.
    /// </summary>
    [KnownType(typeof(PriceFormat59Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat59Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat59Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat59Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat59Choice.PercentagePrice),nameof(PriceFormat59Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat59Choice.AmountPrice),nameof(PriceFormat59Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat59Choice.NotSpecifiedPrice),nameof(PriceFormat59Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat59Choice.IndexPoints),nameof(PriceFormat59Choice.IndexPoints))]
    [IsoId("_ctkvAZKQEeWHWpTQn1FFVg")]
    [DisplayName("Price Format 59 Choice")]
    public abstract partial record PriceFormat59Choice_
    {
    }
}
