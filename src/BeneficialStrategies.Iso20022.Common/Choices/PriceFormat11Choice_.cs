// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price.
    /// </summary>
    [KnownType(typeof(PriceFormat11Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat11Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat11Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat11Choice.PercentagePrice),nameof(PriceFormat11Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat11Choice.AmountPrice),nameof(PriceFormat11Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat11Choice.NotSpecifiedPrice),nameof(PriceFormat11Choice.NotSpecifiedPrice))]
    [IsoId("_Q4EOdNp-Ed-ak6NoX_4Aeg_1637637339")]
    [DisplayName("Price Format 11 Choice")]
    public abstract partial record PriceFormat11Choice_
    {
    }
}
