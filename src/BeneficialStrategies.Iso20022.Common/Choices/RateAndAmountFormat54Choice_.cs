// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate or a deemed rate type and rate or an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat54Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat54Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat54Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(RateAndAmountFormat54Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat54Choice.Rate),nameof(RateAndAmountFormat54Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat54Choice.Amount),nameof(RateAndAmountFormat54Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat54Choice.RateTypeAndAmountAndRateStatus),nameof(RateAndAmountFormat54Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(RateAndAmountFormat54Choice.RateTypeAndRate),nameof(RateAndAmountFormat54Choice.RateTypeAndRate))]
    [IsoId("_TTFAsdEDEeetfps_dpxRmg")]
    [DisplayName("Rate And Amount Format 54 Choice")]
    public abstract partial record RateAndAmountFormat54Choice_
    {
    }
}
