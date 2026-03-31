// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat5Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat5Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat5Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat5Choice.Amount),
        nameof(GrossDividendRateFormat5Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat5Choice.RateTypeAndAmountAndRateStatus),
        nameof(GrossDividendRateFormat5Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat5Choice.NotSpecifiedRate),
        nameof(GrossDividendRateFormat5Choice.NotSpecifiedRate)
    )]
    [IsoId("_e26LIeEREd-1Ktb5rVaajw")]
    [DisplayName("Gross Dividend Rate Format 5 Choice")]
    public abstract record GrossDividendRateFormat5Choice_ { }
}
