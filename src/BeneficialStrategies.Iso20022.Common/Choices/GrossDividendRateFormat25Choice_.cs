// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat25Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat25Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat25Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat25Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat25Choice.Amount),
        nameof(GrossDividendRateFormat25Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat25Choice.AmountAndRateStatus),
        nameof(GrossDividendRateFormat25Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat25Choice.RateTypeAndAmountAndRateStatus),
        nameof(GrossDividendRateFormat25Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat25Choice.NotSpecifiedRate),
        nameof(GrossDividendRateFormat25Choice.NotSpecifiedRate)
    )]
    [IsoId("_ctdaz5KQEeWHWpTQn1FFVg")]
    [DisplayName("Gross Dividend Rate Format 25 Choice")]
    public abstract record GrossDividendRateFormat25Choice_ { }
}
