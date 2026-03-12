// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats to express a net dividend.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat42Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat42Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat42Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat42Choice.Amount),nameof(NetDividendRateFormat42Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat42Choice.AmountAndRateStatus),nameof(NetDividendRateFormat42Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat42Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat42Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_-lxHHwVSEeqjd8n6wD9JVw")]
    [DisplayName("Net Dividend Rate Format 42 Choice")]
    public abstract partial record NetDividendRateFormat42Choice_
    {
    }
}
