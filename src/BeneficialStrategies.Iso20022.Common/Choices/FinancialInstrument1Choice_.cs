// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrument1Choice.Security))]
    [KnownType(typeof(FinancialInstrument1Choice.CashAsset))]
    [KnownType(typeof(FinancialInstrument1Choice.OtherAsset))]
    [JsonDerivedType(
        typeof(FinancialInstrument1Choice.Security),
        nameof(FinancialInstrument1Choice.Security)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrument1Choice.CashAsset),
        nameof(FinancialInstrument1Choice.CashAsset)
    )]
    [JsonDerivedType(
        typeof(FinancialInstrument1Choice.OtherAsset),
        nameof(FinancialInstrument1Choice.OtherAsset)
    )]
    [IsoId("_pCApoEyGEeir2sRRVd9XhA")]
    [DisplayName("Financial Instrument 1 Choice")]
    public abstract record FinancialInstrument1Choice_ { }
}
