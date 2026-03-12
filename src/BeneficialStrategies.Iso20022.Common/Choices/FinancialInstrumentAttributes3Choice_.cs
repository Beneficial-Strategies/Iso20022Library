// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the attributes of the financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentAttributes3Choice.Identification))]
    [KnownType(typeof(FinancialInstrumentAttributes3Choice.Other))]
    [JsonDerivedType(typeof(FinancialInstrumentAttributes3Choice.Identification),nameof(FinancialInstrumentAttributes3Choice.Identification))]
    [JsonDerivedType(typeof(FinancialInstrumentAttributes3Choice.Other),nameof(FinancialInstrumentAttributes3Choice.Other))]
    [IsoId("_KJ36VYG-EeaalK9UbuVGFw")]
    [DisplayName("Financial Instrument Attributes 3 Choice")]
    public abstract partial record FinancialInstrumentAttributes3Choice_
    {
    }
}
