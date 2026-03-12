// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market type.
    /// </summary>
    [KnownType(typeof(MarketType17Choice.Code))]
    [KnownType(typeof(MarketType17Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketType17Choice.Code),nameof(MarketType17Choice.Code))]
    [JsonDerivedType(typeof(MarketType17Choice.Proprietary),nameof(MarketType17Choice.Proprietary))]
    [IsoId("_5W2zCZNLEeWGlc8L7oPDIg")]
    [DisplayName("Market Type 17 Choice")]
    public abstract partial record MarketType17Choice_
    {
    }
}
