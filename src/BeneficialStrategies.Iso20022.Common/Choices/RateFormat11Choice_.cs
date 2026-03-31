// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or a rate type and rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat11Choice.Rate))]
    [KnownType(typeof(RateFormat11Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateFormat11Choice.Rate), nameof(RateFormat11Choice.Rate))]
    [JsonDerivedType(
        typeof(RateFormat11Choice.RateTypeAndRate),
        nameof(RateFormat11Choice.RateTypeAndRate)
    )]
    [IsoId("_QLKPGyeOEeOXAt_43VmZGw")]
    [DisplayName("Rate Format 11 Choice")]
    public abstract record RateFormat11Choice_ { }
}
