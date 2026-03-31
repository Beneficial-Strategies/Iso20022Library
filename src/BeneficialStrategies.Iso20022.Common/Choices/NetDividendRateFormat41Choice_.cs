// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat41Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat41Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat41Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat41Choice.Amount),
        nameof(NetDividendRateFormat41Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat41Choice.AmountAndRateStatus),
        nameof(NetDividendRateFormat41Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat41Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat41Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_-lkh7AVSEeqjd8n6wD9JVw")]
    [DisplayName("Net Dividend Rate Format 41 Choice")]
    public abstract record NetDividendRateFormat41Choice_ { }
}
