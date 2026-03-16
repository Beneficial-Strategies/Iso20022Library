// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat7Choice.Rate))]
    [KnownType(typeof(RateFormat7Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat7Choice.Rate), nameof(RateFormat7Choice.Rate))]
    [JsonDerivedType(
        typeof(RateFormat7Choice.NotSpecifiedRate),
        nameof(RateFormat7Choice.NotSpecifiedRate)
    )]
    [IsoId("_8_swAfmaEeCgTOP8zvX1cw")]
    [DisplayName("Rate Format 7 Choice")]
    public abstract record RateFormat7Choice_ { }
}
