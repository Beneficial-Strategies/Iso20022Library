// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity36Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity36Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity36Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity36Choice.DigitalTokenUnit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity36Choice.Unit),nameof(FinancialInstrumentQuantity36Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity36Choice.FaceAmount),nameof(FinancialInstrumentQuantity36Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity36Choice.AmortisedValue),nameof(FinancialInstrumentQuantity36Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity36Choice.DigitalTokenUnit),nameof(FinancialInstrumentQuantity36Choice.DigitalTokenUnit))]
    [IsoId("_peY03Ti7Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Quantity 36 Choice")]
    public abstract partial record FinancialInstrumentQuantity36Choice_
    {
    }
}
