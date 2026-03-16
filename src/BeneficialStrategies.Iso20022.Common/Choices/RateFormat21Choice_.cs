// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat21Choice.Rate))]
    [KnownType(typeof(RateFormat21Choice.Amount))]
    [KnownType(typeof(RateFormat21Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat21Choice.Rate), nameof(RateFormat21Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat21Choice.Amount), nameof(RateFormat21Choice.Amount))]
    [JsonDerivedType(
        typeof(RateFormat21Choice.NotSpecifiedRate),
        nameof(RateFormat21Choice.NotSpecifiedRate)
    )]
    [IsoId("_ctoZkZKQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Format 21 Choice")]
    public abstract record RateFormat21Choice_ { }
}
