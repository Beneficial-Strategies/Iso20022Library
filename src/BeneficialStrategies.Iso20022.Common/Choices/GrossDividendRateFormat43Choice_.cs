// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Gross Dividend Rate Format43Choice.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat43Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat43Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat43Choice.NotSpecifiedRate))]
    [KnownType(typeof(GrossDividendRateFormat43Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat43Choice.Amount),
        nameof(GrossDividendRateFormat43Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat43Choice.AmountAndRateStatus),
        nameof(GrossDividendRateFormat43Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat43Choice.NotSpecifiedRate),
        nameof(GrossDividendRateFormat43Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat43Choice.RateTypeAndAmountAndRateStatus),
        nameof(GrossDividendRateFormat43Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_En8Uw4VUEe-oeNhl-Tk6YQ")]
    [DisplayName("Gross Dividend Rate Format43Choice")]
    public abstract record GrossDividendRateFormat43Choice_ { }
}
