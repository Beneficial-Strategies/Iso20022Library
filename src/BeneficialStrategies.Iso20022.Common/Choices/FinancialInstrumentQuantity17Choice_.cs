// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity17Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity17Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity17Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity17Choice.Code))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity17Choice.Unit),
        nameof(FinancialInstrumentQuantity17Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity17Choice.FaceAmount),
        nameof(FinancialInstrumentQuantity17Choice.FaceAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity17Choice.AmortisedValue),
        nameof(FinancialInstrumentQuantity17Choice.AmortisedValue)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity17Choice.Code),
        nameof(FinancialInstrumentQuantity17Choice.Code)
    )]
    [IsoId("_fUaVkAgYEeCVlvYcV4HKqQ")]
    [DisplayName("Financial Instrument Quantity 17 Choice")]
    public abstract record FinancialInstrumentQuantity17Choice_ { }
}
