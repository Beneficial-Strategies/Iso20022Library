// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market/client side information.
    /// </summary>
    [KnownType(typeof(MarketClientSide6Choice.Code))]
    [KnownType(typeof(MarketClientSide6Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketClientSide6Choice.Code),nameof(MarketClientSide6Choice.Code))]
    [JsonDerivedType(typeof(MarketClientSide6Choice.Proprietary),nameof(MarketClientSide6Choice.Proprietary))]
    [IsoId("_-0vXIa3KEeey8N0JWnVPUw")]
    [DisplayName("Market Client Side 6 Choice")]
    public abstract partial record MarketClientSide6Choice_
    {
    }
}
