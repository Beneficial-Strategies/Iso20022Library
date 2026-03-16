// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity19Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity19Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity19Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity19Choice.Code))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity19Choice.Unit),
        nameof(FinancialInstrumentQuantity19Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity19Choice.FaceAmount),
        nameof(FinancialInstrumentQuantity19Choice.FaceAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity19Choice.AmortisedValue),
        nameof(FinancialInstrumentQuantity19Choice.AmortisedValue)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity19Choice.Code),
        nameof(FinancialInstrumentQuantity19Choice.Code)
    )]
    [IsoId("_dPPy8fmWEeCcAY_zfcalaA")]
    [DisplayName("Financial Instrument Quantity 19 Choice")]
    public abstract record FinancialInstrumentQuantity19Choice_ { }
}
