// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate or a deemed rate type and rate or an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat52Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat52Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat52Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(RateAndAmountFormat52Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat52Choice.Rate),nameof(RateAndAmountFormat52Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat52Choice.Amount),nameof(RateAndAmountFormat52Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat52Choice.RateTypeAndAmountAndRateStatus),nameof(RateAndAmountFormat52Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(RateAndAmountFormat52Choice.RateTypeAndRate),nameof(RateAndAmountFormat52Choice.RateTypeAndRate))]
    [IsoId("_fFh9EJSoEeeh5JjedkaA_g")]
    [DisplayName("Rate And Amount Format 52 Choice")]
    public abstract partial record RateAndAmountFormat52Choice_
    {
    }
}
