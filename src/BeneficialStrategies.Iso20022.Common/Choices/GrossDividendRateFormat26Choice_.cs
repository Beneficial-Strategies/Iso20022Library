// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat26Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat26Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat26Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat26Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(GrossDividendRateFormat26Choice.Amount),nameof(GrossDividendRateFormat26Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat26Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat26Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat26Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat26Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat26Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat26Choice.NotSpecifiedRate))]
    [IsoId("_ctnLbZKQEeWHWpTQn1FFVg")]
    [DisplayName("Gross Dividend Rate Format 26 Choice")]
    public abstract partial record GrossDividendRateFormat26Choice_
    {
    }
}
