// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of market identification.
    /// </summary>
    [KnownType(typeof(MarketIdentification4Choice.MarketIdentifierCode))]
    [KnownType(typeof(MarketIdentification4Choice.Description))]
    [JsonDerivedType(typeof(MarketIdentification4Choice.MarketIdentifierCode),nameof(MarketIdentification4Choice.MarketIdentifierCode))]
    [JsonDerivedType(typeof(MarketIdentification4Choice.Description),nameof(MarketIdentification4Choice.Description))]
    [IsoId("_04BcYQk_EeGQpPnjvNlciw")]
    [DisplayName("Market Identification 4 Choice")]
    public abstract partial record MarketIdentification4Choice_
    {
    }
}
