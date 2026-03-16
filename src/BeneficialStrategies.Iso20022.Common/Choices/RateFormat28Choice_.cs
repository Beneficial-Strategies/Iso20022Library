// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate Format28Choice.
    /// </summary>
    [KnownType(typeof(RateFormat28Choice.Amount))]
    [KnownType(typeof(RateFormat28Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat28Choice.Amount),nameof(RateFormat28Choice.Amount))]
    [JsonDerivedType(typeof(RateFormat28Choice.Rate),nameof(RateFormat28Choice.Rate))]
    [IsoId("_kv7y05t3Ee-wQIOX0djF2w")]
    [DisplayName("Rate Format28Choice")]
    public abstract partial record RateFormat28Choice_
    {
    }
}
