// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price.
    /// </summary>
    [KnownType(typeof(PriceFormat45Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat45Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat45Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat45Choice.PercentagePrice),nameof(PriceFormat45Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat45Choice.AmountPrice),nameof(PriceFormat45Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat45Choice.NotSpecifiedPrice),nameof(PriceFormat45Choice.NotSpecifiedPrice))]
    [IsoId("_c9r6Q0EJEeWVgfuHGaKtRQ")]
    [DisplayName("Price Format 45 Choice")]
    public abstract partial record PriceFormat45Choice_
    {
    }
}
