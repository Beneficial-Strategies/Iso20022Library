// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity45Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity45Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity45Choice.DigitalTokenUnit))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity45Choice.Unit),
        nameof(FinancialInstrumentQuantity45Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity45Choice.FaceAmount),
        nameof(FinancialInstrumentQuantity45Choice.FaceAmount)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity45Choice.DigitalTokenUnit),
        nameof(FinancialInstrumentQuantity45Choice.DigitalTokenUnit)
    )]
    [IsoId("_wn3tETQ_Ee2id-MjcNoBdw")]
    [DisplayName("Financial Instrument Quantity 45 Choice")]
    public abstract record FinancialInstrumentQuantity45Choice_ { }
}
