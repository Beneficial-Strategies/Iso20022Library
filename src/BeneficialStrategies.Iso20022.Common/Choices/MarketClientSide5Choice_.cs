// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market/client side information.
    /// </summary>
    [KnownType(typeof(MarketClientSide5Choice.Code))]
    [KnownType(typeof(MarketClientSide5Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketClientSide5Choice.Code),nameof(MarketClientSide5Choice.Code))]
    [JsonDerivedType(typeof(MarketClientSide5Choice.Proprietary),nameof(MarketClientSide5Choice.Proprietary))]
    [IsoId("_5m6BTZNLEeWGlc8L7oPDIg")]
    [DisplayName("Market Client Side 5 Choice")]
    public abstract partial record MarketClientSide5Choice_
    {
    }
}
