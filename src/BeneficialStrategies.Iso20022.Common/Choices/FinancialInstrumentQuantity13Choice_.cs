// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways to express the quantity of the financial instrument to be subscribed.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity13Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity13Choice.OrderedAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity13Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity13Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity13Choice.PercentageOfTotalRedemptionAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity13Choice.UnitsNumber),nameof(FinancialInstrumentQuantity13Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity13Choice.OrderedAmount),nameof(FinancialInstrumentQuantity13Choice.OrderedAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity13Choice.NetAmount),nameof(FinancialInstrumentQuantity13Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity13Choice.GrossAmount),nameof(FinancialInstrumentQuantity13Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity13Choice.PercentageOfTotalRedemptionAmount),nameof(FinancialInstrumentQuantity13Choice.PercentageOfTotalRedemptionAmount))]
    [IsoId("_RgJiKtp-Ed-ak6NoX_4Aeg_446864518")]
    [DisplayName("Financial Instrument Quantity 13 Choice")]
    public abstract partial record FinancialInstrumentQuantity13Choice_
    {
    }
}
