// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate, an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat16Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat16Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat16Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat16Choice.Rate),nameof(RateAndAmountFormat16Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat16Choice.NotSpecifiedRate),nameof(RateAndAmountFormat16Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat16Choice.Amount),nameof(RateAndAmountFormat16Choice.Amount))]
    [IsoId("_fM9pwQgYEeCVlvYcV4HKqQ")]
    [DisplayName("Rate And Amount Format 16 Choice")]
    public abstract partial record RateAndAmountFormat16Choice_
    {
    }
}
