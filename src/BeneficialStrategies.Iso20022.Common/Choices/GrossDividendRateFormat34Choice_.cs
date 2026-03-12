// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat34Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat34Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat34Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat34Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(GrossDividendRateFormat34Choice.Amount),nameof(GrossDividendRateFormat34Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat34Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat34Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat34Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat34Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat34Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat34Choice.NotSpecifiedRate))]
    [IsoId("_k9v_Fc3xEee5nJBZsW8MFQ")]
    [DisplayName("Gross Dividend Rate Format 34 Choice")]
    public abstract partial record GrossDividendRateFormat34Choice_
    {
    }
}
