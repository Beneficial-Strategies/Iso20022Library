// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat44Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat44Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat44Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat44Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat44Choice.Amount),
        nameof(NetDividendRateFormat44Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat44Choice.AmountAndRateStatus),
        nameof(NetDividendRateFormat44Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat44Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat44Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat44Choice.NotSpecifiedRate),
        nameof(NetDividendRateFormat44Choice.NotSpecifiedRate)
    )]
    [IsoId("_baDKfwVTEeqjd8n6wD9JVw")]
    [DisplayName("Net Dividend Rate Format 44 Choice")]
    public abstract record NetDividendRateFormat44Choice_ { }
}
