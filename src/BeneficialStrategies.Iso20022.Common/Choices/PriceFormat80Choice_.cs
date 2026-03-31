// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format80Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat80Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat80Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat80Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat80Choice.PercentagePrice))]
    [JsonDerivedType(
        typeof(PriceFormat80Choice.AmountPrice),
        nameof(PriceFormat80Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat80Choice.IndexPoints),
        nameof(PriceFormat80Choice.IndexPoints)
    )]
    [JsonDerivedType(
        typeof(PriceFormat80Choice.NotSpecifiedPrice),
        nameof(PriceFormat80Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat80Choice.PercentagePrice),
        nameof(PriceFormat80Choice.PercentagePrice)
    )]
    [IsoId("_joC6UYV6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Price Format80Choice")]
    public abstract record PriceFormat80Choice_ { }
}
