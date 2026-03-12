// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats to express a net dividend.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat10Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat10Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat10Choice.Amount),nameof(NetDividendRateFormat10Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat10Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat10Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_OCKxMRFbEeKp2ZN13DI_pA")]
    [DisplayName("Net Dividend Rate Format 10 Choice")]
    public abstract partial record NetDividendRateFormat10Choice_
    {
    }
}
