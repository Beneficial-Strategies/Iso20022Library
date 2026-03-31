// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat39Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat39Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat39Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat39Choice.Amount),
        nameof(GrossDividendRateFormat39Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat39Choice.AmountAndRateStatus),
        nameof(GrossDividendRateFormat39Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat39Choice.RateTypeAndAmountAndRateStatus),
        nameof(GrossDividendRateFormat39Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_-lkhhAVSEeqjd8n6wD9JVw")]
    [DisplayName("Gross Dividend Rate Format 39 Choice")]
    public abstract record GrossDividendRateFormat39Choice_ { }
}
