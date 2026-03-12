// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat25Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat25Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat25Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat25Choice.Amount),nameof(NetDividendRateFormat25Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat25Choice.AmountAndRateStatus),nameof(NetDividendRateFormat25Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat25Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat25Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_cj9gGZKQEeWHWpTQn1FFVg")]
    [DisplayName("Net Dividend Rate Format 25 Choice")]
    public abstract partial record NetDividendRateFormat25Choice_
    {
    }
}
