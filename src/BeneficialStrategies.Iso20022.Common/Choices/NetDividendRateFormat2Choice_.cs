// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats to express a net dividend.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat2Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat2Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat2Choice.Amount),
        nameof(NetDividendRateFormat2Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat2Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat2Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_UM2Y9tp-Ed-ak6NoX_4Aeg_-319728264")]
    [DisplayName("Net Dividend Rate Format 2 Choice")]
    public abstract record NetDividendRateFormat2Choice_ { }
}
