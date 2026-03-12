// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat29Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat29Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat29Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat29Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(NetDividendRateFormat29Choice.Amount),nameof(NetDividendRateFormat29Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat29Choice.AmountAndRateStatus),nameof(NetDividendRateFormat29Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat29Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat29Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat29Choice.NotSpecifiedRate),nameof(NetDividendRateFormat29Choice.NotSpecifiedRate))]
    [IsoId("__n1GMZb7Eee8S7xwGG7Veg")]
    [DisplayName("Net Dividend Rate Format 29 Choice")]
    public abstract partial record NetDividendRateFormat29Choice_
    {
    }
}
