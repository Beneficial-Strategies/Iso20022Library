// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat31Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat31Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat31Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat31Choice.Amount),
        nameof(GrossDividendRateFormat31Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat31Choice.AmountAndRateStatus),
        nameof(GrossDividendRateFormat31Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat31Choice.RateTypeAndAmountAndRateStatus),
        nameof(GrossDividendRateFormat31Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_skrJQ83wEee5nJBZsW8MFQ")]
    [DisplayName("Gross Dividend Rate Format 31 Choice")]
    public abstract record GrossDividendRateFormat31Choice_ { }
}
