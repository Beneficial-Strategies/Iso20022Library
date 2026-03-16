// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat28Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat28Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat28Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat28Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat28Choice.Amount),
        nameof(NetDividendRateFormat28Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat28Choice.AmountAndRateStatus),
        nameof(NetDividendRateFormat28Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat28Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat28Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat28Choice.NotSpecifiedRate),
        nameof(NetDividendRateFormat28Choice.NotSpecifiedRate)
    )]
    [IsoId("_ctoZq5KQEeWHWpTQn1FFVg")]
    [DisplayName("Net Dividend Rate Format 28 Choice")]
    public abstract record NetDividendRateFormat28Choice_ { }
}
