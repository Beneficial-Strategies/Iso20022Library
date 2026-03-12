// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat2Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat2Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat2Choice.Amount),nameof(GrossDividendRateFormat2Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat2Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat2Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_UNAJ9tp-Ed-ak6NoX_4Aeg_1829064322")]
    [DisplayName("Gross Dividend Rate Format 2 Choice")]
    public abstract partial record GrossDividendRateFormat2Choice_
    {
    }
}
