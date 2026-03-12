// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity33Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity33Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity33Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity33Choice.DigitalTokenUnit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity33Choice.Unit),nameof(FinancialInstrumentQuantity33Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity33Choice.FaceAmount),nameof(FinancialInstrumentQuantity33Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity33Choice.AmortisedValue),nameof(FinancialInstrumentQuantity33Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity33Choice.DigitalTokenUnit),nameof(FinancialInstrumentQuantity33Choice.DigitalTokenUnit))]
    [IsoId("_Gu-7FRuyEeyhRdHRjakS2w")]
    [DisplayName("Financial Instrument Quantity 33 Choice")]
    public abstract partial record FinancialInstrumentQuantity33Choice_
    {
    }
}
