// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat35Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat35Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat35Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat35Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(NetDividendRateFormat35Choice.Amount),nameof(NetDividendRateFormat35Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat35Choice.AmountAndRateStatus),nameof(NetDividendRateFormat35Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat35Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat35Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat35Choice.NotSpecifiedRate),nameof(NetDividendRateFormat35Choice.NotSpecifiedRate))]
    [IsoId("_k9oDD83xEee5nJBZsW8MFQ")]
    [DisplayName("Net Dividend Rate Format 35 Choice")]
    public abstract partial record NetDividendRateFormat35Choice_
    {
    }
}
