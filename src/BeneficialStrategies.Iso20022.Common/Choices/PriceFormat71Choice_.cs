// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format71Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat71Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat71Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat71Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat71Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat71Choice.AmountPrice),nameof(PriceFormat71Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat71Choice.IndexPoints),nameof(PriceFormat71Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat71Choice.NotSpecifiedPrice),nameof(PriceFormat71Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat71Choice.PercentagePrice),nameof(PriceFormat71Choice.PercentagePrice))]
    [IsoId("_Qe0gcXG2Ee6S2Llv74R19w")]
    [DisplayName("Price Format71Choice")]
    public abstract partial record PriceFormat71Choice_
    {
    }
}
