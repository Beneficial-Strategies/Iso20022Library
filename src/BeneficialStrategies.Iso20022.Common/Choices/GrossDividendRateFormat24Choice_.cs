// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat24Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat24Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat24Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat24Choice.Amount),nameof(GrossDividendRateFormat24Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat24Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat24Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat24Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat24Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_ckMw4ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Gross Dividend Rate Format 24 Choice")]
    public abstract partial record GrossDividendRateFormat24Choice_
    {
    }
}
