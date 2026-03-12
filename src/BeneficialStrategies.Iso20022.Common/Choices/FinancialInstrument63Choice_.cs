// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrument63Choice.Security))]
    [KnownType(typeof(FinancialInstrument63Choice.CashAsset))]
    [KnownType(typeof(FinancialInstrument63Choice.OtherAsset))]
    [JsonDerivedType(typeof(FinancialInstrument63Choice.Security),nameof(FinancialInstrument63Choice.Security))]
    [JsonDerivedType(typeof(FinancialInstrument63Choice.CashAsset),nameof(FinancialInstrument63Choice.CashAsset))]
    [JsonDerivedType(typeof(FinancialInstrument63Choice.OtherAsset),nameof(FinancialInstrument63Choice.OtherAsset))]
    [IsoId("_nPXaoaPvEemf4IaGqCtquA")]
    [DisplayName("Financial Instrument 63 Choice")]
    public abstract partial record FinancialInstrument63Choice_
    {
    }
}
