// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat27Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat27Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat27Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat27Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(GrossDividendRateFormat27Choice.Amount),nameof(GrossDividendRateFormat27Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat27Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat27Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat27Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat27Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat27Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat27Choice.NotSpecifiedRate))]
    [IsoId("_y6LIHZb7Eee8S7xwGG7Veg")]
    [DisplayName("Gross Dividend Rate Format 27 Choice")]
    public abstract partial record GrossDividendRateFormat27Choice_
    {
    }
}
