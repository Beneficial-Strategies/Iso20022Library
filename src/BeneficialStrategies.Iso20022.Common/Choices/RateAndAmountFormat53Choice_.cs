// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate or a deemed rate type and rate or an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat53Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat53Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat53Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat53Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(RateAndAmountFormat53Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat53Choice.Rate),nameof(RateAndAmountFormat53Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat53Choice.Amount),nameof(RateAndAmountFormat53Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat53Choice.NotSpecifiedRate),nameof(RateAndAmountFormat53Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat53Choice.RateTypeAndAmountAndRateStatus),nameof(RateAndAmountFormat53Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(RateAndAmountFormat53Choice.RateTypeAndRate),nameof(RateAndAmountFormat53Choice.RateTypeAndRate))]
    [IsoId("_6SBGUdBaEee0mNiKMkpGNQ")]
    [DisplayName("Rate And Amount Format 53 Choice")]
    public abstract partial record RateAndAmountFormat53Choice_
    {
    }
}
