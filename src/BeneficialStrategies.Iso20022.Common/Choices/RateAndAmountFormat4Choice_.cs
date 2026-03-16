// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat4Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat4Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat4Choice.Amount),
        nameof(RateAndAmountFormat4Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat4Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat4Choice.NotSpecifiedRate)
    )]
    [IsoId("_UO8Dq9p-Ed-ak6NoX_4Aeg_-1134635736")]
    [DisplayName("Rate And Amount Format 4 Choice")]
    public abstract record RateAndAmountFormat4Choice_ { }
}
