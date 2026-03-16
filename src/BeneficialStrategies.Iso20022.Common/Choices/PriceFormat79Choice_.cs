// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format79Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat79Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat79Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat79Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat79Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat79Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat79Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat79Choice.AmountPrice),nameof(PriceFormat79Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat79Choice.AmountPricePerAmount),nameof(PriceFormat79Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat79Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat79Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat79Choice.IndexPoints),nameof(PriceFormat79Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat79Choice.NotSpecifiedPrice),nameof(PriceFormat79Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat79Choice.PercentagePrice),nameof(PriceFormat79Choice.PercentagePrice))]
    [IsoId("_jcPS-YV6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Price Format79Choice")]
    public abstract partial record PriceFormat79Choice_
    {
    }
}
