// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat37Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat37Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat37Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat37Choice.Amount),nameof(NetDividendRateFormat37Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat37Choice.AmountAndRateStatus),nameof(NetDividendRateFormat37Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat37Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat37Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_OROc4eXsEemEj48jhmlA0Q")]
    [DisplayName("Net Dividend Rate Format 37 Choice")]
    public abstract partial record NetDividendRateFormat37Choice_
    {
    }
}
