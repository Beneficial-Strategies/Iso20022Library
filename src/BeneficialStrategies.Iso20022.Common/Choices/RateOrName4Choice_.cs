// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage rate or a rate index or a rate name.
    /// </summary>
    [KnownType(typeof(RateOrName4Choice.Rate))]
    [KnownType(typeof(RateOrName4Choice.RateIndexDetails))]
    [JsonDerivedType(typeof(RateOrName4Choice.Rate),nameof(RateOrName4Choice.Rate))]
    [JsonDerivedType(typeof(RateOrName4Choice.RateIndexDetails),nameof(RateOrName4Choice.RateIndexDetails))]
    [IsoId("_KYxnQRIlEeyLzJfz3xPQNA")]
    [DisplayName("Rate Or Name 4 Choice")]
    public abstract partial record RateOrName4Choice_
    {
    }
}
