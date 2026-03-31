// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat22Choice.Rate))]
    [KnownType(typeof(RateFormat22Choice.Amount))]
    [JsonDerivedType(typeof(RateFormat22Choice.Rate), nameof(RateFormat22Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat22Choice.Amount), nameof(RateFormat22Choice.Amount))]
    [IsoId("_uFrRK68wEee2P-j6wtfM2A")]
    [DisplayName("Rate Format 22 Choice")]
    public abstract record RateFormat22Choice_ { }
}
