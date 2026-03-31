// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate Format30Choice.
    /// </summary>
    [KnownType(typeof(RateFormat30Choice.Amount))]
    [KnownType(typeof(RateFormat30Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateFormat30Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat30Choice.Amount), nameof(RateFormat30Choice.Amount))]
    [JsonDerivedType(
        typeof(RateFormat30Choice.NotSpecifiedRate),
        nameof(RateFormat30Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(typeof(RateFormat30Choice.Rate), nameof(RateFormat30Choice.Rate))]
    [IsoId("_nLl9EZt3Ee-wQIOX0djF2w")]
    [DisplayName("Rate Format30Choice")]
    public abstract record RateFormat30Choice_ { }
}
