// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats to express a net dividend.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat24Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat24Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat24Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat24Choice.Amount),nameof(NetDividendRateFormat24Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat24Choice.AmountAndRateStatus),nameof(NetDividendRateFormat24Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat24Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat24Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_gFdAwWXGEeWht50_j0HXAQ")]
    [DisplayName("Net Dividend Rate Format 24 Choice")]
    public abstract partial record NetDividendRateFormat24Choice_
    {
    }
}
