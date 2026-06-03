// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrument104Choice.Security))]
    [KnownType(typeof(FinancialInstrument104Choice.CashAsset))]
    [KnownType(typeof(FinancialInstrument104Choice.OtherAsset))]
    [JsonDerivedType(typeof(FinancialInstrument104Choice.Security), nameof(FinancialInstrument104Choice.Security))]
    [JsonDerivedType(typeof(FinancialInstrument104Choice.CashAsset), nameof(FinancialInstrument104Choice.CashAsset))]
    [JsonDerivedType(typeof(FinancialInstrument104Choice.OtherAsset), nameof(FinancialInstrument104Choice.OtherAsset))]
    [IsoId("790dc0e5-bd9f-403d-80fb-efcf5b914a98")]
    [DisplayName("Financial Instrument 104 Choice")]
    public abstract record FinancialInstrument104Choice_ { }
}
