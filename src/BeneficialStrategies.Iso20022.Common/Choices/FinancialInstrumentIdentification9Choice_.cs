// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the identification of the financial instruments.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentIdentification9Choice.ISIN))]
    [KnownType(typeof(FinancialInstrumentIdentification9Choice.Index))]
    [JsonDerivedType(typeof(FinancialInstrumentIdentification9Choice.ISIN),nameof(FinancialInstrumentIdentification9Choice.ISIN))]
    [JsonDerivedType(typeof(FinancialInstrumentIdentification9Choice.Index),nameof(FinancialInstrumentIdentification9Choice.Index))]
    [IsoId("_26V3lZ3DEeuwmdq0KtnICg")]
    [DisplayName("Financial Instrument Identification 9 Choice")]
    public abstract partial record FinancialInstrumentIdentification9Choice_
    {
    }
}
