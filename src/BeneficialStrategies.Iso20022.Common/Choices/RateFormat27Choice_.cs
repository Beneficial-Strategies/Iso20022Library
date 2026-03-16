// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate Format27Choice.
    /// </summary>
    [KnownType(typeof(RateFormat27Choice.Amount))]
    [KnownType(typeof(RateFormat27Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat27Choice.Amount),nameof(RateFormat27Choice.Amount))]
    [JsonDerivedType(typeof(RateFormat27Choice.Rate),nameof(RateFormat27Choice.Rate))]
    [IsoId("_KbcyIYV-Ee-ufOxNNkEXmg")]
    [DisplayName("Rate Format27Choice")]
    public abstract partial record RateFormat27Choice_
    {
    }
}
