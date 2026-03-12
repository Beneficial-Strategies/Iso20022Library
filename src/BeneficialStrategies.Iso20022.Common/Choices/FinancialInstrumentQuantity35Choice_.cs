// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity35Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity35Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity35Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity35Choice.Code))]
    [KnownType(typeof(FinancialInstrumentQuantity35Choice.DigitalTokenUnit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity35Choice.Unit),nameof(FinancialInstrumentQuantity35Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity35Choice.FaceAmount),nameof(FinancialInstrumentQuantity35Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity35Choice.AmortisedValue),nameof(FinancialInstrumentQuantity35Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity35Choice.Code),nameof(FinancialInstrumentQuantity35Choice.Code))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity35Choice.DigitalTokenUnit),nameof(FinancialInstrumentQuantity35Choice.DigitalTokenUnit))]
    [IsoId("_lyZogxu1EeyhRdHRjakS2w")]
    [DisplayName("Financial Instrument Quantity 35 Choice")]
    public abstract partial record FinancialInstrumentQuantity35Choice_
    {
    }
}
