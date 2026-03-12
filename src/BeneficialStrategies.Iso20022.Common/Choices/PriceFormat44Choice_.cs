// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or index points.
    /// </summary>
    [KnownType(typeof(PriceFormat44Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat44Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat44Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat44Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat44Choice.PercentagePrice),nameof(PriceFormat44Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat44Choice.AmountPrice),nameof(PriceFormat44Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat44Choice.NotSpecifiedPrice),nameof(PriceFormat44Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat44Choice.IndexPoints),nameof(PriceFormat44Choice.IndexPoints))]
    [IsoId("_J1Q0u0EFEeWVgfuHGaKtRQ")]
    [DisplayName("Price Format 44 Choice")]
    public abstract partial record PriceFormat44Choice_
    {
    }
}
