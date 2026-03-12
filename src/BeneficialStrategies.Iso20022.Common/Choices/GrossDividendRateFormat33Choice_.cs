// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat33Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat33Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat33Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat33Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(GrossDividendRateFormat33Choice.Amount),nameof(GrossDividendRateFormat33Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat33Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat33Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat33Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat33Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat33Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat33Choice.NotSpecifiedRate))]
    [IsoId("_k9oCm83xEee5nJBZsW8MFQ")]
    [DisplayName("Gross Dividend Rate Format 33 Choice")]
    public abstract partial record GrossDividendRateFormat33Choice_
    {
    }
}
