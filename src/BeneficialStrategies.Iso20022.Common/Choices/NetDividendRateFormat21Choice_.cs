// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat21Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat21Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat21Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat21Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(NetDividendRateFormat21Choice.Amount),nameof(NetDividendRateFormat21Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat21Choice.AmountAndRateStatus),nameof(NetDividendRateFormat21Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat21Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat21Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat21Choice.NotSpecifiedRate),nameof(NetDividendRateFormat21Choice.NotSpecifiedRate))]
    [IsoId("_Gr_NkWOWEeWYYI9c62RCjw")]
    [DisplayName("Net Dividend Rate Format 21 Choice")]
    public abstract partial record NetDividendRateFormat21Choice_
    {
    }
}
