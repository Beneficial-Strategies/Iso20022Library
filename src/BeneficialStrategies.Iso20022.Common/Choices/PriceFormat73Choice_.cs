// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format73Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat73Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat73Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat73Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat73Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat73Choice.AmountPrice),nameof(PriceFormat73Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat73Choice.IndexPoints),nameof(PriceFormat73Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat73Choice.NotSpecifiedPrice),nameof(PriceFormat73Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat73Choice.PercentagePrice),nameof(PriceFormat73Choice.PercentagePrice))]
    [IsoId("_Cp-90YV6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Price Format73Choice")]
    public abstract partial record PriceFormat73Choice_
    {
    }
}
