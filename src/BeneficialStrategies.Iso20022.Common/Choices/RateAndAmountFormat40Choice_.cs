// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate or a rate type and rate or an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat40Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat40Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat40Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat40Choice.Rate),nameof(RateAndAmountFormat40Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat40Choice.Amount),nameof(RateAndAmountFormat40Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat40Choice.RateTypeAndRate),nameof(RateAndAmountFormat40Choice.RateTypeAndRate))]
    [IsoId("__EcZkUEIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate And Amount Format 40 Choice")]
    public abstract partial record RateAndAmountFormat40Choice_
    {
    }
}
