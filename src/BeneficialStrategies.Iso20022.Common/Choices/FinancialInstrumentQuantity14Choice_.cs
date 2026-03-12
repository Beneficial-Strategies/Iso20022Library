// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity14Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity14Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity14Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity14Choice.Code))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity14Choice.Unit),nameof(FinancialInstrumentQuantity14Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity14Choice.FaceAmount),nameof(FinancialInstrumentQuantity14Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity14Choice.AmortisedValue),nameof(FinancialInstrumentQuantity14Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity14Choice.Code),nameof(FinancialInstrumentQuantity14Choice.Code))]
    [IsoId("_Wr_78Np-Ed-ak6NoX_4Aeg_-719785587")]
    [DisplayName("Financial Instrument Quantity 14 Choice")]
    public abstract partial record FinancialInstrumentQuantity14Choice_
    {
    }
}
