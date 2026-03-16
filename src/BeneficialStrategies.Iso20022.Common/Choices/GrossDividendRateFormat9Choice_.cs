// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat9Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat9Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat9Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat9Choice.Amount),
        nameof(GrossDividendRateFormat9Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat9Choice.RateTypeAndAmountAndRateStatus),
        nameof(GrossDividendRateFormat9Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat9Choice.NotSpecifiedRate),
        nameof(GrossDividendRateFormat9Choice.NotSpecifiedRate)
    )]
    [IsoId("_jsvqURLnEeKJ5uSjVyVvug")]
    [DisplayName("Gross Dividend Rate Format 9 Choice")]
    public abstract record GrossDividendRateFormat9Choice_ { }
}
