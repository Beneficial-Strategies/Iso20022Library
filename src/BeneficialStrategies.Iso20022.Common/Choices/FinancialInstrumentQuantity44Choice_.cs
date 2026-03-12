// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity44Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity44Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity44Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity44Choice.Code))]
    [KnownType(typeof(FinancialInstrumentQuantity44Choice.DigitalTokenUnit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity44Choice.Unit),nameof(FinancialInstrumentQuantity44Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity44Choice.FaceAmount),nameof(FinancialInstrumentQuantity44Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity44Choice.AmortisedValue),nameof(FinancialInstrumentQuantity44Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity44Choice.Code),nameof(FinancialInstrumentQuantity44Choice.Code))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity44Choice.DigitalTokenUnit),nameof(FinancialInstrumentQuantity44Choice.DigitalTokenUnit))]
    [IsoId("_ptJrOzi7Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Quantity 44 Choice")]
    public abstract partial record FinancialInstrumentQuantity44Choice_
    {
    }
}
