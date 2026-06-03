// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrument101Choice.Security))]
    [KnownType(typeof(FinancialInstrument101Choice.CashAsset))]
    [KnownType(typeof(FinancialInstrument101Choice.OtherAsset))]
    [JsonDerivedType(typeof(FinancialInstrument101Choice.Security), nameof(FinancialInstrument101Choice.Security))]
    [JsonDerivedType(typeof(FinancialInstrument101Choice.CashAsset), nameof(FinancialInstrument101Choice.CashAsset))]
    [JsonDerivedType(typeof(FinancialInstrument101Choice.OtherAsset), nameof(FinancialInstrument101Choice.OtherAsset))]
    [IsoId("031f41a7-4ff4-4ed2-8e28-9371c92c1cc2")]
    [DisplayName("Financial Instrument 101 Choice")]
    public abstract record FinancialInstrument101Choice_ { }
}
