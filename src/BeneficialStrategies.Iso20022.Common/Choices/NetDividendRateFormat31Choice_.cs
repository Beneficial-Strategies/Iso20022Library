// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat31Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat31Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat31Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat31Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(NetDividendRateFormat31Choice.Amount),nameof(NetDividendRateFormat31Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat31Choice.AmountAndRateStatus),nameof(NetDividendRateFormat31Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat31Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat31Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat31Choice.NotSpecifiedRate),nameof(NetDividendRateFormat31Choice.NotSpecifiedRate))]
    [IsoId("_SR2f4Zb9Eee8S7xwGG7Veg")]
    [DisplayName("Net Dividend Rate Format 31 Choice")]
    public abstract partial record NetDividendRateFormat31Choice_
    {
    }
}
