// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage rate or a rate index or a rate name.
    /// </summary>
    [KnownType(typeof(RateOrType1Choice.Rate))]
    [KnownType(typeof(RateOrType1Choice.Type))]
    [JsonDerivedType(typeof(RateOrType1Choice.Rate),nameof(RateOrType1Choice.Rate))]
    [JsonDerivedType(typeof(RateOrType1Choice.Type),nameof(RateOrType1Choice.Type))]
    [IsoId("_XAtno8IiEeuexrfMa3dl_Q")]
    [DisplayName("Rate Or Type 1 Choice")]
    public abstract partial record RateOrType1Choice_
    {
    }
}
