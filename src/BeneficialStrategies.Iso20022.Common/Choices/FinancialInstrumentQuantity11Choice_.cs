// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways to express the quantity of the financial instrument to be subscribed to or redeemed.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity11Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity11Choice.OrderedAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity11Choice.HoldingsRate))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity11Choice.UnitsNumber),nameof(FinancialInstrumentQuantity11Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity11Choice.OrderedAmount),nameof(FinancialInstrumentQuantity11Choice.OrderedAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity11Choice.HoldingsRate),nameof(FinancialInstrumentQuantity11Choice.HoldingsRate))]
    [IsoId("_RhV08tp-Ed-ak6NoX_4Aeg_1444004749")]
    [DisplayName("Financial Instrument Quantity 11 Choice")]
    public abstract partial record FinancialInstrumentQuantity11Choice_
    {
    }
}
