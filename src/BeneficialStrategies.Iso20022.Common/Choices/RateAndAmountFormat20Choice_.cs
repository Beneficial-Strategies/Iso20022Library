// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate or a rate type and rate or an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat20Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat20Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat20Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat20Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat20Choice.Rate),nameof(RateAndAmountFormat20Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat20Choice.NotSpecifiedRate),nameof(RateAndAmountFormat20Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat20Choice.Amount),nameof(RateAndAmountFormat20Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat20Choice.RateTypeAndRate),nameof(RateAndAmountFormat20Choice.RateTypeAndRate))]
    [IsoId("_S4q7DyeKEeOXAt_43VmZGw")]
    [DisplayName("Rate And Amount Format 20 Choice")]
    public abstract partial record RateAndAmountFormat20Choice_
    {
    }
}
