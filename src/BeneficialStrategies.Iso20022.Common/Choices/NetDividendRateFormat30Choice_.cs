// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat30Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat30Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat30Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat30Choice.Amount),
        nameof(NetDividendRateFormat30Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat30Choice.AmountAndRateStatus),
        nameof(NetDividendRateFormat30Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat30Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat30Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_AUTxtZb8Eee8S7xwGG7Veg")]
    [DisplayName("Net Dividend Rate Format 30 Choice")]
    public abstract record NetDividendRateFormat30Choice_ { }
}
