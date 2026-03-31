// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat10Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat10Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat10Choice.Amount),
        nameof(GrossDividendRateFormat10Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat10Choice.RateTypeAndAmountAndRateStatus),
        nameof(GrossDividendRateFormat10Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_lIYh4RLnEeKJ5uSjVyVvug")]
    [DisplayName("Gross Dividend Rate Format 10 Choice")]
    public abstract record GrossDividendRateFormat10Choice_ { }
}
