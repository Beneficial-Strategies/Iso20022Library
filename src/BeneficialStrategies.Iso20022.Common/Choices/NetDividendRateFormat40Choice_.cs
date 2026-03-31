// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats to express a net dividend.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat40Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat40Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat40Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat40Choice.Amount),
        nameof(NetDividendRateFormat40Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat40Choice.AmountAndRateStatus),
        nameof(NetDividendRateFormat40Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat40Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat40Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_iwEfpeXsEemEj48jhmlA0Q")]
    [DisplayName("Net Dividend Rate Format 40 Choice")]
    public abstract record NetDividendRateFormat40Choice_ { }
}
