// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat42Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat42Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat42Choice.Amount),
        nameof(RateAndAmountFormat42Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat42Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat42Choice.NotSpecifiedRate)
    )]
    [IsoId("_9AMGAUEMEeWVgfuHGaKtRQ")]
    [DisplayName("Rate And Amount Format 42 Choice")]
    public abstract record RateAndAmountFormat42Choice_ { }
}
