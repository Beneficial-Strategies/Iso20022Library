// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat22Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat22Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat22Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat22Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat22Choice.Amount),
        nameof(NetDividendRateFormat22Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat22Choice.AmountAndRateStatus),
        nameof(NetDividendRateFormat22Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat22Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat22Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat22Choice.NotSpecifiedRate),
        nameof(NetDividendRateFormat22Choice.NotSpecifiedRate)
    )]
    [IsoId("_Osj8UWOXEeWYYI9c62RCjw")]
    [DisplayName("Net Dividend Rate Format 22 Choice")]
    public abstract record NetDividendRateFormat22Choice_ { }
}
