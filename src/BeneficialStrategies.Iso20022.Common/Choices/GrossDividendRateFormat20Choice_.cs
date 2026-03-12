// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat20Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat20Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat20Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat20Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(GrossDividendRateFormat20Choice.Amount),nameof(GrossDividendRateFormat20Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat20Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat20Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat20Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat20Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat20Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat20Choice.NotSpecifiedRate))]
    [IsoId("_wnN5YWOWEeWYYI9c62RCjw")]
    [DisplayName("Gross Dividend Rate Format 20 Choice")]
    public abstract partial record GrossDividendRateFormat20Choice_
    {
    }
}
