// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat28Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat28Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat28Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat28Choice.Amount),
        nameof(GrossDividendRateFormat28Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat28Choice.AmountAndRateStatus),
        nameof(GrossDividendRateFormat28Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat28Choice.RateTypeAndAmountAndRateStatus),
        nameof(GrossDividendRateFormat28Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_0HiTG5b7Eee8S7xwGG7Veg")]
    [DisplayName("Gross Dividend Rate Format 28 Choice")]
    public abstract record GrossDividendRateFormat28Choice_ { }
}
