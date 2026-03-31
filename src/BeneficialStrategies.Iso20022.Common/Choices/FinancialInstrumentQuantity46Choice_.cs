// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity46Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity46Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity46Choice.DigitalTokenUnit))]
    [KnownType(typeof(FinancialInstrumentQuantity46Choice.Code))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity46Choice.Unit),
        nameof(FinancialInstrumentQuantity46Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity46Choice.FaceAmount),
        nameof(FinancialInstrumentQuantity46Choice.FaceAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity46Choice.DigitalTokenUnit),
        nameof(FinancialInstrumentQuantity46Choice.DigitalTokenUnit)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity46Choice.Code),
        nameof(FinancialInstrumentQuantity46Choice.Code)
    )]
    [IsoId("_DcYV6DT5Ee2j2eQlcOSMKg")]
    [DisplayName("Financial Instrument Quantity 46 Choice")]
    public abstract record FinancialInstrumentQuantity46Choice_ { }
}
