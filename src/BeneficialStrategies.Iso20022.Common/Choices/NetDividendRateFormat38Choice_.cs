// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat38Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat38Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat38Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat38Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat38Choice.Amount),
        nameof(NetDividendRateFormat38Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat38Choice.AmountAndRateStatus),
        nameof(NetDividendRateFormat38Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat38Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat38Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat38Choice.NotSpecifiedRate),
        nameof(NetDividendRateFormat38Choice.NotSpecifiedRate)
    )]
    [IsoId("_PDp_ZeXsEemEj48jhmlA0Q")]
    [DisplayName("Net Dividend Rate Format 38 Choice")]
    public abstract record NetDividendRateFormat38Choice_ { }
}
