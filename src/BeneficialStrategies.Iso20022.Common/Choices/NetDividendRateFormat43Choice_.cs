// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat43Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat43Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat43Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat43Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat43Choice.Amount),
        nameof(NetDividendRateFormat43Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat43Choice.AmountAndRateStatus),
        nameof(NetDividendRateFormat43Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat43Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat43Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat43Choice.NotSpecifiedRate),
        nameof(NetDividendRateFormat43Choice.NotSpecifiedRate)
    )]
    [IsoId("_bZ6BiwVTEeqjd8n6wD9JVw")]
    [DisplayName("Net Dividend Rate Format 43 Choice")]
    public abstract record NetDividendRateFormat43Choice_ { }
}
