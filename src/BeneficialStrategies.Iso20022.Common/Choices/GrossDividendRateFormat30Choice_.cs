// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat30Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat30Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat30Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat30Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(GrossDividendRateFormat30Choice.Amount),nameof(GrossDividendRateFormat30Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat30Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat30Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat30Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat30Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat30Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat30Choice.NotSpecifiedRate))]
    [IsoId("_6wixtZb8Eee8S7xwGG7Veg")]
    [DisplayName("Gross Dividend Rate Format 30 Choice")]
    public abstract partial record GrossDividendRateFormat30Choice_
    {
    }
}
