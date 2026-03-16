// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format89Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat89Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat89Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat89Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat89Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat89Choice.AmountPrice),nameof(PriceFormat89Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat89Choice.IndexPoints),nameof(PriceFormat89Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat89Choice.NotSpecifiedPrice),nameof(PriceFormat89Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat89Choice.PercentagePrice),nameof(PriceFormat89Choice.PercentagePrice))]
    [IsoId("_l6XmjJt3Ee-wQIOX0djF2w")]
    [DisplayName("Price Format89Choice")]
    public abstract partial record PriceFormat89Choice_
    {
    }
}
