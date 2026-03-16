// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an indicator or a proprietary code to specify whether the security is a temporary security.
    /// </summary>
    [KnownType(typeof(TemporaryFinancialInstrumentIndicator4Choice.TemporaryIndicator))]
    [KnownType(typeof(TemporaryFinancialInstrumentIndicator4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TemporaryFinancialInstrumentIndicator4Choice.TemporaryIndicator),
        nameof(TemporaryFinancialInstrumentIndicator4Choice.TemporaryIndicator)
    )]
    [JsonDerivedType(
        typeof(TemporaryFinancialInstrumentIndicator4Choice.Proprietary),
        nameof(TemporaryFinancialInstrumentIndicator4Choice.Proprietary)
    )]
    [IsoId("_cj_8O5KQEeWHWpTQn1FFVg")]
    [DisplayName("Temporary Financial Instrument Indicator 4 Choice")]
    public abstract record TemporaryFinancialInstrumentIndicator4Choice_ { }
}
