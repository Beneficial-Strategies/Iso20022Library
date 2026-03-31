// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat23Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat23Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat23Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat23Choice.Amount),
        nameof(GrossDividendRateFormat23Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat23Choice.AmountAndRateStatus),
        nameof(GrossDividendRateFormat23Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat23Choice.RateTypeAndAmountAndRateStatus),
        nameof(GrossDividendRateFormat23Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_cj85p5KQEeWHWpTQn1FFVg")]
    [DisplayName("Gross Dividend Rate Format 23 Choice")]
    public abstract record GrossDividendRateFormat23Choice_ { }
}
