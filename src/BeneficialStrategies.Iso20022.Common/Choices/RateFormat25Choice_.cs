// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate Format25Choice.
    /// </summary>
    [KnownType(typeof(RateFormat25Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateFormat25Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat25Choice.NotSpecifiedRate),nameof(RateFormat25Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat25Choice.Rate),nameof(RateFormat25Choice.Rate))]
    [IsoId("_qZrbkYV5Ee-oeNhl-Tk6YQ")]
    [DisplayName("Rate Format25Choice")]
    public abstract partial record RateFormat25Choice_
    {
    }
}
