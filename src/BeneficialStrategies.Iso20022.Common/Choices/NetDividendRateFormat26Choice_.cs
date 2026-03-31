// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats to express a net dividend.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat26Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat26Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat26Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat26Choice.Amount),
        nameof(NetDividendRateFormat26Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat26Choice.AmountAndRateStatus),
        nameof(NetDividendRateFormat26Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat26Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat26Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_ckN-r5KQEeWHWpTQn1FFVg")]
    [DisplayName("Net Dividend Rate Format 26 Choice")]
    public abstract record NetDividendRateFormat26Choice_ { }
}
