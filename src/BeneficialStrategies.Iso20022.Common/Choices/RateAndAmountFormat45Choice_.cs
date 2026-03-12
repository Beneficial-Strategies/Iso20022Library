// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate or a rate type and rate or an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat45Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat45Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat45Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat45Choice.Rate),nameof(RateAndAmountFormat45Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat45Choice.Amount),nameof(RateAndAmountFormat45Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat45Choice.RateTypeAndRate),nameof(RateAndAmountFormat45Choice.RateTypeAndRate))]
    [IsoId("_cj-HW5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate And Amount Format 45 Choice")]
    public abstract partial record RateAndAmountFormat45Choice_
    {
    }
}
