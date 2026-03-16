// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format62Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat62Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat62Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat62Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(RateAndAmountFormat62Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat62Choice.Amount),nameof(RateAndAmountFormat62Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat62Choice.Rate),nameof(RateAndAmountFormat62Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat62Choice.RateTypeAndAmountAndRateStatus),nameof(RateAndAmountFormat62Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(RateAndAmountFormat62Choice.RateTypeAndRate),nameof(RateAndAmountFormat62Choice.RateTypeAndRate))]
    [IsoId("_XiTlkYV8Ee-ufOxNNkEXmg")]
    [DisplayName("Rate And Amount Format62Choice")]
    public abstract partial record RateAndAmountFormat62Choice_
    {
    }
}
