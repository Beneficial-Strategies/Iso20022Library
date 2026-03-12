// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat32Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat32Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat32Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat32Choice.Amount),nameof(GrossDividendRateFormat32Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat32Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat32Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat32Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat32Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_sk1go83wEee5nJBZsW8MFQ")]
    [DisplayName("Gross Dividend Rate Format 32 Choice")]
    public abstract partial record GrossDividendRateFormat32Choice_
    {
    }
}
