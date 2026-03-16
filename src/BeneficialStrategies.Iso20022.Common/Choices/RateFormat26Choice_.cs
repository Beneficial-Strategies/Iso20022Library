// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate Format26Choice.
    /// </summary>
    [KnownType(typeof(RateFormat26Choice.Amount))]
    [KnownType(typeof(RateFormat26Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateFormat26Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat26Choice.Amount),nameof(RateFormat26Choice.Amount))]
    [JsonDerivedType(typeof(RateFormat26Choice.NotSpecifiedRate),nameof(RateFormat26Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat26Choice.Rate),nameof(RateFormat26Choice.Rate))]
    [IsoId("_v35iUYV6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Rate Format26Choice")]
    public abstract partial record RateFormat26Choice_
    {
    }
}
