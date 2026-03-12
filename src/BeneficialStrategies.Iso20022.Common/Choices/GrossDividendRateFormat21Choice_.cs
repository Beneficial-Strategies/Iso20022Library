// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat21Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat21Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat21Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat21Choice.Amount),nameof(GrossDividendRateFormat21Choice.Amount))]
    [JsonDerivedType(typeof(GrossDividendRateFormat21Choice.AmountAndRateStatus),nameof(GrossDividendRateFormat21Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(GrossDividendRateFormat21Choice.RateTypeAndAmountAndRateStatus),nameof(GrossDividendRateFormat21Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_w0oJQWXFEeWht50_j0HXAQ")]
    [DisplayName("Gross Dividend Rate Format 21 Choice")]
    public abstract partial record GrossDividendRateFormat21Choice_
    {
    }
}
