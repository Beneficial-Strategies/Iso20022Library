// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat7Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat7Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat7Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat7Choice.AmountPricePerAmount))]
    [JsonDerivedType(
        typeof(PriceFormat7Choice.PercentagePrice),
        nameof(PriceFormat7Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat7Choice.AmountPrice),
        nameof(PriceFormat7Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat7Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormat7Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [JsonDerivedType(
        typeof(PriceFormat7Choice.AmountPricePerAmount),
        nameof(PriceFormat7Choice.AmountPricePerAmount)
    )]
    [IsoId("_Q4qEUNp-Ed-ak6NoX_4Aeg_354313475")]
    [DisplayName("Price Format 7 Choice")]
    public abstract record PriceFormat7Choice_ { }
}
