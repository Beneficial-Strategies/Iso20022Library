// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat27Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat27Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat27Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat27Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat27Choice.Amount),
        nameof(NetDividendRateFormat27Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat27Choice.AmountAndRateStatus),
        nameof(NetDividendRateFormat27Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat27Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat27Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat27Choice.NotSpecifiedRate),
        nameof(NetDividendRateFormat27Choice.NotSpecifiedRate)
    )]
    [IsoId("_cteBQZKQEeWHWpTQn1FFVg")]
    [DisplayName("Net Dividend Rate Format 27 Choice")]
    public abstract record NetDividendRateFormat27Choice_ { }
}
