// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat39Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat39Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat39Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat39Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(NetDividendRateFormat39Choice.Amount),nameof(NetDividendRateFormat39Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat39Choice.AmountAndRateStatus),nameof(NetDividendRateFormat39Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat39Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat39Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat39Choice.NotSpecifiedRate),nameof(NetDividendRateFormat39Choice.NotSpecifiedRate))]
    [IsoId("_h-ht8eXsEemEj48jhmlA0Q")]
    [DisplayName("Net Dividend Rate Format 39 Choice")]
    public abstract partial record NetDividendRateFormat39Choice_
    {
    }
}
