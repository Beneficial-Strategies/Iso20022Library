// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrument62Choice.Security))]
    [KnownType(typeof(FinancialInstrument62Choice.CashAsset))]
    [KnownType(typeof(FinancialInstrument62Choice.OtherAsset))]
    [JsonDerivedType(typeof(FinancialInstrument62Choice.Security),nameof(FinancialInstrument62Choice.Security))]
    [JsonDerivedType(typeof(FinancialInstrument62Choice.CashAsset),nameof(FinancialInstrument62Choice.CashAsset))]
    [JsonDerivedType(typeof(FinancialInstrument62Choice.OtherAsset),nameof(FinancialInstrument62Choice.OtherAsset))]
    [IsoId("_pv-M0Zy1Eem54rMzia0iag")]
    [DisplayName("Financial Instrument 62 Choice")]
    public abstract partial record FinancialInstrument62Choice_
    {
    }
}
