// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the attributes of the financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentAttributes4Choice.Identification))]
    [KnownType(typeof(FinancialInstrumentAttributes4Choice.Other))]
    [JsonDerivedType(typeof(FinancialInstrumentAttributes4Choice.Identification),nameof(FinancialInstrumentAttributes4Choice.Identification))]
    [JsonDerivedType(typeof(FinancialInstrumentAttributes4Choice.Other),nameof(FinancialInstrumentAttributes4Choice.Other))]
    [IsoId("_F042MZ3CEeuwmdq0KtnICg")]
    [DisplayName("Financial Instrument Attributes 4 Choice")]
    public abstract partial record FinancialInstrumentAttributes4Choice_
    {
    }
}
