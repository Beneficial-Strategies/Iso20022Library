// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Market Identification5Choice.
    /// </summary>
    [KnownType(typeof(MarketIdentification5Choice.Description))]
    [KnownType(typeof(MarketIdentification5Choice.MarketIdentifierCode))]
    [JsonDerivedType(
        typeof(MarketIdentification5Choice.Description),
        nameof(MarketIdentification5Choice.Description)
    )]
    [JsonDerivedType(
        typeof(MarketIdentification5Choice.MarketIdentifierCode),
        nameof(MarketIdentification5Choice.MarketIdentifierCode)
    )]
    [IsoId("_-k8eE4VYEe-Pv9KR9bv9IA")]
    [DisplayName("Market Identification5Choice")]
    public abstract record MarketIdentification5Choice_ { }
}
