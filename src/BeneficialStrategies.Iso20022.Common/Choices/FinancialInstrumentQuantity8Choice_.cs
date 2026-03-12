// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways to express the quantity of the financial instrument to be redeemed.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity8Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity8Choice.OrderedAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity8Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity8Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity8Choice.HoldingsRate))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity8Choice.UnitsNumber),nameof(FinancialInstrumentQuantity8Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity8Choice.OrderedAmount),nameof(FinancialInstrumentQuantity8Choice.OrderedAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity8Choice.NetAmount),nameof(FinancialInstrumentQuantity8Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity8Choice.GrossAmount),nameof(FinancialInstrumentQuantity8Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity8Choice.HoldingsRate),nameof(FinancialInstrumentQuantity8Choice.HoldingsRate))]
    [IsoId("_Rg5JBtp-Ed-ak6NoX_4Aeg_1589726171")]
    [DisplayName("Financial Instrument Quantity 8 Choice")]
    public abstract partial record FinancialInstrumentQuantity8Choice_
    {
    }
}
