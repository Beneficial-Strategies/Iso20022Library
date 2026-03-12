// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the attributes of the financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentAttributes5Choice.Identification))]
    [KnownType(typeof(FinancialInstrumentAttributes5Choice.AlternateIdentification))]
    [KnownType(typeof(FinancialInstrumentAttributes5Choice.Other))]
    [JsonDerivedType(typeof(FinancialInstrumentAttributes5Choice.Identification),nameof(FinancialInstrumentAttributes5Choice.Identification))]
    [JsonDerivedType(typeof(FinancialInstrumentAttributes5Choice.AlternateIdentification),nameof(FinancialInstrumentAttributes5Choice.AlternateIdentification))]
    [JsonDerivedType(typeof(FinancialInstrumentAttributes5Choice.Other),nameof(FinancialInstrumentAttributes5Choice.Other))]
    [IsoId("_6fVwkZicEe2f7NHvXATP5g")]
    [DisplayName("Financial Instrument Attributes 5 Choice")]
    public abstract partial record FinancialInstrumentAttributes5Choice_
    {
    }
}
