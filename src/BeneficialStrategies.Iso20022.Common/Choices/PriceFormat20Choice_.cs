// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat20Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat20Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat20Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat20Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat20Choice.AmountPricePerAmount))]
    [JsonDerivedType(
        typeof(PriceFormat20Choice.PercentagePrice),
        nameof(PriceFormat20Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat20Choice.AmountPrice),
        nameof(PriceFormat20Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat20Choice.NotSpecifiedPrice),
        nameof(PriceFormat20Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat20Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormat20Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [JsonDerivedType(
        typeof(PriceFormat20Choice.AmountPricePerAmount),
        nameof(PriceFormat20Choice.AmountPricePerAmount)
    )]
    [IsoId("_sJ7aAeEJEd-udr336SN7mQ")]
    [DisplayName("Price Format 20 Choice")]
    public abstract record PriceFormat20Choice_ { }
}
