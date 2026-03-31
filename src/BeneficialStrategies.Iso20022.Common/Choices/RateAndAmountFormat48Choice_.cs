// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat48Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat48Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat48Choice.Amount),
        nameof(RateAndAmountFormat48Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat48Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat48Choice.NotSpecifiedRate)
    )]
    [IsoId("_ctpnW5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate And Amount Format 48 Choice")]
    public abstract record RateAndAmountFormat48Choice_ { }
}
