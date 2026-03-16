// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format71Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat71Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat71Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat71Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat71Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(RateAndAmountFormat71Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat71Choice.Amount),nameof(RateAndAmountFormat71Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat71Choice.NotSpecifiedRate),nameof(RateAndAmountFormat71Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat71Choice.Rate),nameof(RateAndAmountFormat71Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat71Choice.RateTypeAndAmountAndRateStatus),nameof(RateAndAmountFormat71Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(RateAndAmountFormat71Choice.RateTypeAndRate),nameof(RateAndAmountFormat71Choice.RateTypeAndRate))]
    [IsoId("_l6aCNZt3Ee-wQIOX0djF2w")]
    [DisplayName("Rate And Amount Format71Choice")]
    public abstract partial record RateAndAmountFormat71Choice_
    {
    }
}
