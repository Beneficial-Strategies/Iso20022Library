// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat22Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat22Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat22Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat22Choice.Amount),
        nameof(GrossDividendRateFormat22Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat22Choice.AmountAndRateStatus),
        nameof(GrossDividendRateFormat22Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat22Choice.RateTypeAndAmountAndRateStatus),
        nameof(GrossDividendRateFormat22Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_ChudIWXGEeWht50_j0HXAQ")]
    [DisplayName("Gross Dividend Rate Format 22 Choice")]
    public abstract record GrossDividendRateFormat22Choice_ { }
}
