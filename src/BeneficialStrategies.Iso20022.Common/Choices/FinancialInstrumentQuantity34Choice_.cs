// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity34Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity34Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity34Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity34Choice.Code))]
    [KnownType(typeof(FinancialInstrumentQuantity34Choice.DigitalTokenUnit))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity34Choice.Unit),
        nameof(FinancialInstrumentQuantity34Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity34Choice.FaceAmount),
        nameof(FinancialInstrumentQuantity34Choice.FaceAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity34Choice.AmortisedValue),
        nameof(FinancialInstrumentQuantity34Choice.AmortisedValue)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity34Choice.Code),
        nameof(FinancialInstrumentQuantity34Choice.Code)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity34Choice.DigitalTokenUnit),
        nameof(FinancialInstrumentQuantity34Choice.DigitalTokenUnit)
    )]
    [IsoId("_lMyPmRu0EeyhRdHRjakS2w")]
    [DisplayName("Financial Instrument Quantity 34 Choice")]
    public abstract record FinancialInstrumentQuantity34Choice_ { }
}
