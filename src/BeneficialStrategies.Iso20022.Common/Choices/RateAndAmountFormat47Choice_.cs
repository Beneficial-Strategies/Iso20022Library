// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate or a rate type and rate or an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat47Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat47Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat47Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat47Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat47Choice.Rate),nameof(RateAndAmountFormat47Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat47Choice.NotSpecifiedRate),nameof(RateAndAmountFormat47Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat47Choice.Amount),nameof(RateAndAmountFormat47Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat47Choice.RateTypeAndRate),nameof(RateAndAmountFormat47Choice.RateTypeAndRate))]
    [IsoId("_cteocZKQEeWHWpTQn1FFVg")]
    [DisplayName("Rate And Amount Format 47 Choice")]
    public abstract partial record RateAndAmountFormat47Choice_
    {
    }
}
