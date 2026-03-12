// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat42Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat42Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat42Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat42Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(GrossDividendRateFormat42Choice.Amount),nameof(GrossDividendRateFormat42Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat42Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat42Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat42Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat42Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat42Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat42Choice.NotSpecifiedRate))]
    [IsoId("_bZ_lFwVTEeqjd8n6wD9JVw")]
    [DisplayName("Gross Dividend Rate Format 42 Choice")]
    public abstract partial record GrossDividendRateFormat42Choice_
    {
    }
}
