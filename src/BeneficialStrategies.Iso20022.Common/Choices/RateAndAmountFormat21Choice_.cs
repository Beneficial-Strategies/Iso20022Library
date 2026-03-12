// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate or a rate type and rate or an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat21Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat21Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat21Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat21Choice.Rate),nameof(RateAndAmountFormat21Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat21Choice.Amount),nameof(RateAndAmountFormat21Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat21Choice.RateTypeAndRate),nameof(RateAndAmountFormat21Choice.RateTypeAndRate))]
    [IsoId("_y_GIICeOEeOXAt_43VmZGw")]
    [DisplayName("Rate And Amount Format 21 Choice")]
    public abstract partial record RateAndAmountFormat21Choice_
    {
    }
}
