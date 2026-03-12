// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat37Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat37Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat37Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat37Choice.Amount),nameof(GrossDividendRateFormat37Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat37Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat37Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat37Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat37Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_Y-U4--XsEemEj48jhmlA0Q")]
    [DisplayName("Gross Dividend Rate Format 37 Choice")]
    public abstract partial record GrossDividendRateFormat37Choice_
    {
    }
}
