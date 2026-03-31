// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat1Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat1Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat1Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(NetDividendRateFormat1Choice.Amount),
        nameof(NetDividendRateFormat1Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat1Choice.RateTypeAndAmountAndRateStatus),
        nameof(NetDividendRateFormat1Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(NetDividendRateFormat1Choice.NotSpecifiedRate),
        nameof(NetDividendRateFormat1Choice.NotSpecifiedRate)
    )]
    [IsoId("_UOfXvNp-Ed-ak6NoX_4Aeg_1518190054")]
    [DisplayName("Net Dividend Rate Format 1 Choice")]
    public abstract record NetDividendRateFormat1Choice_ { }
}
