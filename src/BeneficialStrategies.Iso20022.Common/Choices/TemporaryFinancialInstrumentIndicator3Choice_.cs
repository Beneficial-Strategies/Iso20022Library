// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an indicator or a proprietary code to specify whether the security is a temporary security.
    /// </summary>
    [KnownType(typeof(TemporaryFinancialInstrumentIndicator3Choice.TemporaryIndicator))]
    [KnownType(typeof(TemporaryFinancialInstrumentIndicator3Choice.Proprietary))]
    [JsonDerivedType(typeof(TemporaryFinancialInstrumentIndicator3Choice.TemporaryIndicator),nameof(TemporaryFinancialInstrumentIndicator3Choice.TemporaryIndicator))]
    [JsonDerivedType(typeof(TemporaryFinancialInstrumentIndicator3Choice.Proprietary),nameof(TemporaryFinancialInstrumentIndicator3Choice.Proprietary))]
    [IsoId("_KJSKkUEKEeWVgfuHGaKtRQ")]
    [DisplayName("Temporary Financial Instrument Indicator 3 Choice")]
    public abstract partial record TemporaryFinancialInstrumentIndicator3Choice_
    {
    }
}
