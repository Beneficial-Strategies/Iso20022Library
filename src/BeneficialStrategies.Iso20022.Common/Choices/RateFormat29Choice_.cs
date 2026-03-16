// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate Format29Choice.
    /// </summary>
    [KnownType(typeof(RateFormat29Choice.Amount))]
    [KnownType(typeof(RateFormat29Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateFormat29Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat29Choice.Amount),nameof(RateFormat29Choice.Amount))]
    [JsonDerivedType(typeof(RateFormat29Choice.NotSpecifiedRate),nameof(RateFormat29Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat29Choice.Rate),nameof(RateFormat29Choice.Rate))]
    [IsoId("_l6W_SZt3Ee-wQIOX0djF2w")]
    [DisplayName("Rate Format29Choice")]
    public abstract partial record RateFormat29Choice_
    {
    }
}
