// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format81Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat81Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat81Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat81Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat81Choice.AmountPrice),nameof(PriceFormat81Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat81Choice.NotSpecifiedPrice),nameof(PriceFormat81Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat81Choice.PercentagePrice),nameof(PriceFormat81Choice.PercentagePrice))]
    [IsoId("_jzkNwYV6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Price Format81Choice")]
    public abstract partial record PriceFormat81Choice_
    {
    }
}
