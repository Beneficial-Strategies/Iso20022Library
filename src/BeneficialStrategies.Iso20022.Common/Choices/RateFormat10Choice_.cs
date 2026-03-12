// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or a rate type and rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat10Choice.Rate))]
    [KnownType(typeof(RateFormat10Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateFormat10Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateFormat10Choice.Rate),nameof(RateFormat10Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat10Choice.NotSpecifiedRate),nameof(RateFormat10Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat10Choice.RateTypeAndRate),nameof(RateFormat10Choice.RateTypeAndRate))]
    [IsoId("_CR-rCieJEeOXAt_43VmZGw")]
    [DisplayName("Rate Format 10 Choice")]
    public abstract partial record RateFormat10Choice_
    {
    }
}
