// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice for identifying the underlying instruments that a derivative can consist of.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentIdentification8Choice.Single))]
    [KnownType(typeof(FinancialInstrumentIdentification8Choice.Basket))]
    [JsonDerivedType(
        typeof(FinancialInstrumentIdentification8Choice.Single),
        nameof(FinancialInstrumentIdentification8Choice.Single)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentIdentification8Choice.Basket),
        nameof(FinancialInstrumentIdentification8Choice.Basket)
    )]
    [IsoId("_2fXy153DEeuwmdq0KtnICg")]
    [DisplayName("Financial Instrument Identification 8 Choice")]
    public abstract record FinancialInstrumentIdentification8Choice_ { }
}
