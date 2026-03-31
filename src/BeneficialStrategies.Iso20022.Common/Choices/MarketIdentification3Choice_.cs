// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of market identification.
    /// </summary>
    [KnownType(typeof(MarketIdentification3Choice.MarketIdentifierCode))]
    [KnownType(typeof(MarketIdentification3Choice.Description))]
    [JsonDerivedType(
        typeof(MarketIdentification3Choice.MarketIdentifierCode),
        nameof(MarketIdentification3Choice.MarketIdentifierCode)
    )]
    [JsonDerivedType(
        typeof(MarketIdentification3Choice.Description),
        nameof(MarketIdentification3Choice.Description)
    )]
    [IsoId("_AcingtokEeC60axPepSq7g_278659251")]
    [DisplayName("Market Identification 3 Choice")]
    public abstract record MarketIdentification3Choice_ { }
}
