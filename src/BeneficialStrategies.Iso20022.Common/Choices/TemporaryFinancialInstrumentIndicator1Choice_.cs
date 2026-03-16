// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an indicator or a proprietary code to specify whether the security is a temporary security.
    /// </summary>
    [KnownType(typeof(TemporaryFinancialInstrumentIndicator1Choice.TemporaryIndicator))]
    [KnownType(typeof(TemporaryFinancialInstrumentIndicator1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TemporaryFinancialInstrumentIndicator1Choice.TemporaryIndicator),
        nameof(TemporaryFinancialInstrumentIndicator1Choice.TemporaryIndicator)
    )]
    [JsonDerivedType(
        typeof(TemporaryFinancialInstrumentIndicator1Choice.Proprietary),
        nameof(TemporaryFinancialInstrumentIndicator1Choice.Proprietary)
    )]
    [IsoId("_Q08B89p-Ed-ak6NoX_4Aeg_-1040584730")]
    [DisplayName("Temporary Financial Instrument Indicator 1 Choice")]
    public abstract record TemporaryFinancialInstrumentIndicator1Choice_ { }
}
