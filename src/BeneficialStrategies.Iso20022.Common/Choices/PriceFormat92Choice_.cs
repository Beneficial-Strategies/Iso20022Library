// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format92Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat92Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat92Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat92Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat92Choice.AmountPrice),nameof(PriceFormat92Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat92Choice.NotSpecifiedPrice),nameof(PriceFormat92Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat92Choice.PercentagePrice),nameof(PriceFormat92Choice.PercentagePrice))]
    [IsoId("_nLjgi5t3Ee-wQIOX0djF2w")]
    [DisplayName("Price Format92Choice")]
    public abstract partial record PriceFormat92Choice_
    {
    }
}
