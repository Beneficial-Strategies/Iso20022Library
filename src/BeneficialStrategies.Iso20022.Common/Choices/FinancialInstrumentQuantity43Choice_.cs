// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity43Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity43Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity43Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity43Choice.Code))]
    [KnownType(typeof(FinancialInstrumentQuantity43Choice.DigitalTokenUnit))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity43Choice.Unit),
        nameof(FinancialInstrumentQuantity43Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity43Choice.FaceAmount),
        nameof(FinancialInstrumentQuantity43Choice.FaceAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity43Choice.AmortisedValue),
        nameof(FinancialInstrumentQuantity43Choice.AmortisedValue)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity43Choice.Code),
        nameof(FinancialInstrumentQuantity43Choice.Code)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity43Choice.DigitalTokenUnit),
        nameof(FinancialInstrumentQuantity43Choice.DigitalTokenUnit)
    )]
    [IsoId("_ptGAfzi7Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Quantity 43 Choice")]
    public abstract record FinancialInstrumentQuantity43Choice_ { }
}
