// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat38Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat38Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat38Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat38Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(GrossDividendRateFormat38Choice.Amount),nameof(GrossDividendRateFormat38Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat38Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat38Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat38Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat38Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat38Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat38Choice.NotSpecifiedRate))]
    [IsoId("_aQmZK-XsEemEj48jhmlA0Q")]
    [DisplayName("Gross Dividend Rate Format 38 Choice")]
    public abstract partial record GrossDividendRateFormat38Choice_
    {
    }
}
