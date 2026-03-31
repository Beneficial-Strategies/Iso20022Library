// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat7Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat7Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat7Choice.Amount),
        nameof(NetDividendRateFormat7Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat7Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat7Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_0kyc8QFgEeGUnupuEvvOAg")]
    [DisplayName("Net Dividend Rate Format 7 Choice")]
    public abstract record NetDividendRateFormat7Choice_ { }
}
