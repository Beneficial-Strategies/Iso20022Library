// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat36Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat36Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat36Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat36Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(GrossDividendRateFormat36Choice.Amount),nameof(GrossDividendRateFormat36Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat36Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat36Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat36Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat36Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat36Choice.NotSpecifiedRate),nameof(GrossDividendRateFormat36Choice.NotSpecifiedRate))]
    [IsoId("_DE35h-XsEemEj48jhmlA0Q")]
    [DisplayName("Gross Dividend Rate Format 36 Choice")]
    public abstract partial record GrossDividendRateFormat36Choice_
    {
    }
}
