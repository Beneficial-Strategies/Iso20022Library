// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat41Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat41Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat41Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat41Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat41Choice.Amount),
        nameof(GrossDividendRateFormat41Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat41Choice.AmountAndRateStatus),
        nameof(GrossDividendRateFormat41Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat41Choice.RateTypeAndAmountAndRateStatus),
        nameof(GrossDividendRateFormat41Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat41Choice.NotSpecifiedRate),
        nameof(GrossDividendRateFormat41Choice.NotSpecifiedRate)
    )]
    [IsoId("_bZ6BFwVTEeqjd8n6wD9JVw")]
    [DisplayName("Gross Dividend Rate Format 41 Choice")]
    public abstract record GrossDividendRateFormat41Choice_ { }
}
