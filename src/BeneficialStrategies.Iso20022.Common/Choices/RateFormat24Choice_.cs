// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate Format24Choice.
    /// </summary>
    [KnownType(typeof(RateFormat24Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateFormat24Choice.Rate))]
    [JsonDerivedType(
        typeof(RateFormat24Choice.NotSpecifiedRate),
        nameof(RateFormat24Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(typeof(RateFormat24Choice.Rate), nameof(RateFormat24Choice.Rate))]
    [IsoId("_oCGVyYV4Ee-oeNhl-Tk6YQ")]
    [DisplayName("Rate Format24Choice")]
    public abstract record RateFormat24Choice_ { }
}
