// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrument102Choice.Security))]
    [KnownType(typeof(FinancialInstrument102Choice.CashAsset))]
    [KnownType(typeof(FinancialInstrument102Choice.OtherAsset))]
    [JsonDerivedType(typeof(FinancialInstrument102Choice.Security), nameof(FinancialInstrument102Choice.Security))]
    [JsonDerivedType(typeof(FinancialInstrument102Choice.CashAsset), nameof(FinancialInstrument102Choice.CashAsset))]
    [JsonDerivedType(typeof(FinancialInstrument102Choice.OtherAsset), nameof(FinancialInstrument102Choice.OtherAsset))]
    [IsoId("f9ddd7b2-6461-409f-8ce8-800b94b67ac4")]
    [DisplayName("Financial Instrument 102 Choice")]
    public abstract record FinancialInstrument102Choice_ { }
}
