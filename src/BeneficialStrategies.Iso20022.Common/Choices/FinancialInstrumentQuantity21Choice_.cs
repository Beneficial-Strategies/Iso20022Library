// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity21Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity21Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity21Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity21Choice.Code))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity21Choice.Unit),nameof(FinancialInstrumentQuantity21Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity21Choice.FaceAmount),nameof(FinancialInstrumentQuantity21Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity21Choice.AmortisedValue),nameof(FinancialInstrumentQuantity21Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity21Choice.Code),nameof(FinancialInstrumentQuantity21Choice.Code))]
    [IsoId("_N-fhCQU-EeGZxNLgzisRtw")]
    [DisplayName("Financial Instrument Quantity 21 Choice")]
    public abstract partial record FinancialInstrumentQuantity21Choice_
    {
    }
}
