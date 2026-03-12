// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat11Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat11Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat11Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(NetDividendRateFormat11Choice.Amount),nameof(NetDividendRateFormat11Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat11Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat11Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat11Choice.NotSpecifiedRate),nameof(NetDividendRateFormat11Choice.NotSpecifiedRate))]
    [IsoId("_2fTxcRLnEeKJ5uSjVyVvug")]
    [DisplayName("Net Dividend Rate Format 11 Choice")]
    public abstract partial record NetDividendRateFormat11Choice_
    {
    }
}
