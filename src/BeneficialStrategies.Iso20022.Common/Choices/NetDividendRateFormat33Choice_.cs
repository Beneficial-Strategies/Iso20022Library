// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat33Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat33Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat33Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat33Choice.Amount),nameof(NetDividendRateFormat33Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat33Choice.AmountAndRateStatus),nameof(NetDividendRateFormat33Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat33Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat33Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_skrJq83wEee5nJBZsW8MFQ")]
    [DisplayName("Net Dividend Rate Format 33 Choice")]
    public abstract partial record NetDividendRateFormat33Choice_
    {
    }
}
