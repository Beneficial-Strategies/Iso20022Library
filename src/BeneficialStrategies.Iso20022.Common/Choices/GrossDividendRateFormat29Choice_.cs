// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat29Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat29Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat29Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat29Choice.Amount),
        nameof(GrossDividendRateFormat29Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat29Choice.AmountAndRateStatus),
        nameof(GrossDividendRateFormat29Choice.AmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRateFormat29Choice.RateTypeAndAmountAndRateStatus),
        nameof(GrossDividendRateFormat29Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_6AoXsZb8Eee8S7xwGG7Veg")]
    [DisplayName("Gross Dividend Rate Format 29 Choice")]
    public abstract record GrossDividendRateFormat29Choice_ { }
}
