// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat9Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat9Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat9Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(NetDividendRateFormat9Choice.Amount),nameof(NetDividendRateFormat9Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat9Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat9Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat9Choice.NotSpecifiedRate),nameof(NetDividendRateFormat9Choice.NotSpecifiedRate))]
    [IsoId("_PELn3xFbEeKp2ZN13DI_pA")]
    [DisplayName("Net Dividend Rate Format 9 Choice")]
    public abstract partial record NetDividendRateFormat9Choice_
    {
    }
}
