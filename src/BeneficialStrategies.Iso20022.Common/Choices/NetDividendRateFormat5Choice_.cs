// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat5Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat5Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat5Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat5Choice.Amount),
        nameof(NetDividendRateFormat5Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat5Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat5Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat5Choice.NotSpecifiedRate),
        nameof(NetDividendRateFormat5Choice.NotSpecifiedRate)
    )]
    [IsoId("__XFDgOwOEd-sn-FiNtktcA")]
    [DisplayName("Net Dividend Rate Format 5 Choice")]
    public abstract record NetDividendRateFormat5Choice_ { }
}
