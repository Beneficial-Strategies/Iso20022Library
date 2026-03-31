// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat23Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat23Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat23Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat23Choice.Amount),
        nameof(NetDividendRateFormat23Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat23Choice.AmountAndRateStatus),
        nameof(NetDividendRateFormat23Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat23Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat23Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_VS0koWXGEeWht50_j0HXAQ")]
    [DisplayName("Net Dividend Rate Format 23 Choice")]
    public abstract record NetDividendRateFormat23Choice_ { }
}
