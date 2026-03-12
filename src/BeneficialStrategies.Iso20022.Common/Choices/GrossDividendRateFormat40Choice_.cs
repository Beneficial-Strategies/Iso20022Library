// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat40Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat40Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat40Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat40Choice.Amount),nameof(GrossDividendRateFormat40Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat40Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat40Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat40Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat40Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_-lv7PwVSEeqjd8n6wD9JVw")]
    [DisplayName("Gross Dividend Rate Format 40 Choice")]
    public abstract partial record GrossDividendRateFormat40Choice_
    {
    }
}
