// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways to express the quantity of the financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity10Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity10Choice.OrderedAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity10Choice.HoldingsRate))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity10Choice.UnitsNumber),nameof(FinancialInstrumentQuantity10Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity10Choice.OrderedAmount),nameof(FinancialInstrumentQuantity10Choice.OrderedAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity10Choice.HoldingsRate),nameof(FinancialInstrumentQuantity10Choice.HoldingsRate))]
    [IsoId("_RgmOF9p-Ed-ak6NoX_4Aeg_2104922749")]
    [DisplayName("Financial Instrument Quantity 10 Choice")]
    public abstract partial record FinancialInstrumentQuantity10Choice_
    {
    }
}
