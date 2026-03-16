// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity22Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity22Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity22Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity22Choice.Code))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity22Choice.Unit),
        nameof(FinancialInstrumentQuantity22Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity22Choice.FaceAmount),
        nameof(FinancialInstrumentQuantity22Choice.FaceAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity22Choice.AmortisedValue),
        nameof(FinancialInstrumentQuantity22Choice.AmortisedValue)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity22Choice.Code),
        nameof(FinancialInstrumentQuantity22Choice.Code)
    )]
    [IsoId("_N-fhSQU-EeGZxNLgzisRtw")]
    [DisplayName("Financial Instrument Quantity 22 Choice")]
    public abstract record FinancialInstrumentQuantity22Choice_ { }
}
