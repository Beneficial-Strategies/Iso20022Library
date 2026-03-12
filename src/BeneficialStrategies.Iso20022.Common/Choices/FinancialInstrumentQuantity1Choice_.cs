// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity1Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity1Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity1Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity1Choice.Unit),nameof(FinancialInstrumentQuantity1Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity1Choice.FaceAmount),nameof(FinancialInstrumentQuantity1Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity1Choice.AmortisedValue),nameof(FinancialInstrumentQuantity1Choice.AmortisedValue))]
    [IsoId("_SokiyNp-Ed-ak6NoX_4Aeg_-1672157653")]
    [DisplayName("Financial Instrument Quantity 1 Choice")]
    public abstract partial record FinancialInstrumentQuantity1Choice_
    {
    }
}
