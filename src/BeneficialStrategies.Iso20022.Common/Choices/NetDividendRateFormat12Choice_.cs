// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat12Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat12Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat12Choice.Amount),
        nameof(NetDividendRateFormat12Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat12Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat12Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_3guyPxLnEeKJ5uSjVyVvug")]
    [DisplayName("Net Dividend Rate Format 12 Choice")]
    public abstract record NetDividendRateFormat12Choice_ { }
}
