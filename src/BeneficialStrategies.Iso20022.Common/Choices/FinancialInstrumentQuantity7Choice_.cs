// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways to express the quantity of the financial instrument to be subscribed.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity7Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity7Choice.OrderedAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity7Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity7Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity7Choice.UnitsNumber),nameof(FinancialInstrumentQuantity7Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity7Choice.OrderedAmount),nameof(FinancialInstrumentQuantity7Choice.OrderedAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity7Choice.NetAmount),nameof(FinancialInstrumentQuantity7Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity7Choice.GrossAmount),nameof(FinancialInstrumentQuantity7Choice.GrossAmount))]
    [IsoId("_Rg5JAdp-Ed-ak6NoX_4Aeg_554727766")]
    [DisplayName("Financial Instrument Quantity 7 Choice")]
    public abstract partial record FinancialInstrumentQuantity7Choice_
    {
    }
}
