// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrument103Choice.Security))]
    [KnownType(typeof(FinancialInstrument103Choice.CashAsset))]
    [KnownType(typeof(FinancialInstrument103Choice.OtherAsset))]
    [JsonDerivedType(typeof(FinancialInstrument103Choice.Security), nameof(FinancialInstrument103Choice.Security))]
    [JsonDerivedType(typeof(FinancialInstrument103Choice.CashAsset), nameof(FinancialInstrument103Choice.CashAsset))]
    [JsonDerivedType(typeof(FinancialInstrument103Choice.OtherAsset), nameof(FinancialInstrument103Choice.OtherAsset))]
    [IsoId("2a2c2444-9a4a-4bf1-9bbf-ab72289ecc2c")]
    [DisplayName("Financial Instrument 103 Choice")]
    public abstract record FinancialInstrument103Choice_ { }
}
