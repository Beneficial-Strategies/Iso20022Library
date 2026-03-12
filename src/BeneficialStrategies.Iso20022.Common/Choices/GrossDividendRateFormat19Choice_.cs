// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat19Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat19Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat19Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat19Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(GrossDividendRateFormat19Choice.Amount),nameof(GrossDividendRateFormat19Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat19Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat19Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat19Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat19Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat19Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat19Choice.NotSpecifiedRate))]
    [IsoId("_xR_moWOUEeWYYI9c62RCjw")]
    [DisplayName("Gross Dividend Rate Format 19 Choice")]
    public abstract partial record GrossDividendRateFormat19Choice_
    {
    }
}
