// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat36Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat36Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat36Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat36Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(NetDividendRateFormat36Choice.Amount),nameof(NetDividendRateFormat36Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat36Choice.AmountAndRateStatus),nameof(NetDividendRateFormat36Choice.AmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat36Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat36Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat36Choice.NotSpecifiedRate),nameof(NetDividendRateFormat36Choice.NotSpecifiedRate))]
    [IsoId("_k9xM083xEee5nJBZsW8MFQ")]
    [DisplayName("Net Dividend Rate Format 36 Choice")]
    public abstract partial record NetDividendRateFormat36Choice_
    {
    }
}
