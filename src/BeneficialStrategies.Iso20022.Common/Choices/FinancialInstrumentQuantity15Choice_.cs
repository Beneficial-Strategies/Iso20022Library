// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity15Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity15Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity15Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity15Choice.Unit),nameof(FinancialInstrumentQuantity15Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity15Choice.FaceAmount),nameof(FinancialInstrumentQuantity15Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity15Choice.AmortisedValue),nameof(FinancialInstrumentQuantity15Choice.AmortisedValue))]
    [IsoId("_Wr_79dp-Ed-ak6NoX_4Aeg_695777575")]
    [DisplayName("Financial Instrument Quantity 15 Choice")]
    public abstract partial record FinancialInstrumentQuantity15Choice_
    {
    }
}
