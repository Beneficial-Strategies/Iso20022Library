// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the identification of the financial instruments.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentIdentification6Choice.ISIN))]
    [KnownType(typeof(FinancialInstrumentIdentification6Choice.Index))]
    [JsonDerivedType(
        typeof(FinancialInstrumentIdentification6Choice.ISIN),
        nameof(FinancialInstrumentIdentification6Choice.ISIN)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrumentIdentification6Choice.Index),
        nameof(FinancialInstrumentIdentification6Choice.Index)
    )]
    [IsoId("_ImVPSX5aEea2k7EBUopqxw")]
    [DisplayName("Financial Instrument Identification 6 Choice")]
    public abstract record FinancialInstrumentIdentification6Choice_ { }
}
