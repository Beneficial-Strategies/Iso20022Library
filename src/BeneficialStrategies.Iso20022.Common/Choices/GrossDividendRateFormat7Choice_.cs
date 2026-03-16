// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat7Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat7Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat7Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat7Choice.Amount),
        nameof(GrossDividendRateFormat7Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat7Choice.RateTypeAndAmountAndRateStatus),
        nameof(GrossDividendRateFormat7Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat7Choice.NotSpecifiedRate),
        nameof(GrossDividendRateFormat7Choice.NotSpecifiedRate)
    )]
    [IsoId("_nEgpwRFaEeKp2ZN13DI_pA")]
    [DisplayName("Gross Dividend Rate Format 7 Choice")]
    public abstract record GrossDividendRateFormat7Choice_ { }
}
