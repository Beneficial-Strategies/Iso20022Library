// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity31Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity31Choice.FaceAmount))]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity31Choice.Unit),
        nameof(FinancialInstrumentQuantity31Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentQuantity31Choice.FaceAmount),
        nameof(FinancialInstrumentQuantity31Choice.FaceAmount)
    )]
    [IsoId("_CUJft89pEee4rfBIKt5cSg")]
    [DisplayName("Financial Instrument Quantity 31 Choice")]
    public abstract record FinancialInstrumentQuantity31Choice_ { }
}
