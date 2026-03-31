// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate, an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat3Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat3Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat3Choice.Amount))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat3Choice.Rate),
        nameof(RateAndAmountFormat3Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat3Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat3Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat3Choice.Amount),
        nameof(RateAndAmountFormat3Choice.Amount)
    )]
    [IsoId("_UPF0qtp-Ed-ak6NoX_4Aeg_282901144")]
    [DisplayName("Rate And Amount Format 3 Choice")]
    public abstract record RateAndAmountFormat3Choice_ { }
}
