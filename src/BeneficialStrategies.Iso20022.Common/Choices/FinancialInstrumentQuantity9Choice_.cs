// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways to express the quantity of the financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity9Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity9Choice.OrderedAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity9Choice.UnitsNumber),nameof(FinancialInstrumentQuantity9Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity9Choice.OrderedAmount),nameof(FinancialInstrumentQuantity9Choice.OrderedAmount))]
    [IsoId("_RhC6A9p-Ed-ak6NoX_4Aeg_1213138425")]
    [DisplayName("Financial Instrument Quantity 9 Choice")]
    public abstract partial record FinancialInstrumentQuantity9Choice_
    {
    }
}
