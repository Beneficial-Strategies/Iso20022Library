// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats to express a net dividend.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat34Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat34Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat34Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat34Choice.Amount),nameof(NetDividendRateFormat34Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat34Choice.AmountAndRateStatus),nameof(NetDividendRateFormat34Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat34Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat34Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_sk1htc3wEee5nJBZsW8MFQ")]
    [DisplayName("Net Dividend Rate Format 34 Choice")]
    public abstract partial record NetDividendRateFormat34Choice_
    {
    }
}
