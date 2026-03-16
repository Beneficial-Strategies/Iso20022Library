// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate, an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat37Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat37Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat37Choice.Amount))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat37Choice.Rate),
        nameof(RateAndAmountFormat37Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat37Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat37Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat37Choice.Amount),
        nameof(RateAndAmountFormat37Choice.Amount)
    )]
    [IsoId("_qDDni0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Rate And Amount Format 37 Choice")]
    public abstract record RateAndAmountFormat37Choice_ { }
}
