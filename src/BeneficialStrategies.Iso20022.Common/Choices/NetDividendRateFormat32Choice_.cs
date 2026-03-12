// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats to express a net dividend.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat32Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat32Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat32Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat32Choice.Amount),nameof(NetDividendRateFormat32Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat32Choice.AmountAndRateStatus),nameof(NetDividendRateFormat32Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat32Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat32Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_S_-xNZb9Eee8S7xwGG7Veg")]
    [DisplayName("Net Dividend Rate Format 32 Choice")]
    public abstract partial record NetDividendRateFormat32Choice_
    {
    }
}
