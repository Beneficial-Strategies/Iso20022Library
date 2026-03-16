// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity20Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity20Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity20Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity20Choice.Code))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity20Choice.Unit),
        nameof(FinancialInstrumentQuantity20Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity20Choice.FaceAmount),
        nameof(FinancialInstrumentQuantity20Choice.FaceAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity20Choice.AmortisedValue),
        nameof(FinancialInstrumentQuantity20Choice.AmortisedValue)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity20Choice.Code),
        nameof(FinancialInstrumentQuantity20Choice.Code)
    )]
    [IsoId("_pPlzMQFIEeGhYJiRaPcH8g")]
    [DisplayName("Financial Instrument Quantity 20 Choice")]
    public abstract record FinancialInstrumentQuantity20Choice_ { }
}
