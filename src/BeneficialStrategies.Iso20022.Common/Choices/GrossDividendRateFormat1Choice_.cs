// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat1Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat1Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat1Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(GrossDividendRateFormat1Choice.Amount),nameof(GrossDividendRateFormat1Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat1Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat1Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat1Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat1Choice.NotSpecifiedRate))]
    [IsoId("_UO8DpNp-Ed-ak6NoX_4Aeg_577708294")]
    [DisplayName("Gross Dividend Rate Format 1 Choice")]
    public abstract partial record GrossDividendRateFormat1Choice_
    {
    }
}
