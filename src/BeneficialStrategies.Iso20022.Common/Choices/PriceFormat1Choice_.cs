// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express a price.
    /// </summary>
    [KnownType(typeof(PriceFormat1Choice.Amount))]
    [KnownType(typeof(PriceFormat1Choice.Rate))]
    [KnownType(typeof(PriceFormat1Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat1Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat1Choice.NotSpecified))]
    [JsonDerivedType(typeof(PriceFormat1Choice.Amount),nameof(PriceFormat1Choice.Amount))]
    [JsonDerivedType(typeof(PriceFormat1Choice.Rate),nameof(PriceFormat1Choice.Rate))]
    [JsonDerivedType(typeof(PriceFormat1Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat1Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat1Choice.AmountPricePerAmount),nameof(PriceFormat1Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat1Choice.NotSpecified),nameof(PriceFormat1Choice.NotSpecified))]
    [IsoId("_QatkFdp-Ed-ak6NoX_4Aeg_-958538176")]
    [DisplayName("Price Format 1 Choice")]
    public abstract partial record PriceFormat1Choice_
    {
    }
}
