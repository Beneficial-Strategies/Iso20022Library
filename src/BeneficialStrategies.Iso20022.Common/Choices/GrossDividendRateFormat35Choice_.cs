// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat35Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat35Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat35Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat35Choice.Amount),
        nameof(GrossDividendRateFormat35Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat35Choice.AmountAndRateStatus),
        nameof(GrossDividendRateFormat35Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat35Choice.RateTypeAndAmountAndRateStatus),
        nameof(GrossDividendRateFormat35Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_Bxatk-XsEemEj48jhmlA0Q")]
    [DisplayName("Gross Dividend Rate Format 35 Choice")]
    public abstract record GrossDividendRateFormat35Choice_ { }
}
