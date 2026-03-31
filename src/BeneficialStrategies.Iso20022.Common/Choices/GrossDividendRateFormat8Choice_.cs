// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat8Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat8Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat8Choice.Amount),
        nameof(GrossDividendRateFormat8Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat8Choice.RateTypeAndAmountAndRateStatus),
        nameof(GrossDividendRateFormat8Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_mDsF8RFaEeKp2ZN13DI_pA")]
    [DisplayName("Gross Dividend Rate Format 8 Choice")]
    public abstract record GrossDividendRateFormat8Choice_ { }
}
