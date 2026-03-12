// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the block trade information.
    /// </summary>
    [KnownType(typeof(BlockTrade5Choice.Code))]
    [KnownType(typeof(BlockTrade5Choice.Proprietary))]
    [JsonDerivedType(typeof(BlockTrade5Choice.Code),nameof(BlockTrade5Choice.Code))]
    [JsonDerivedType(typeof(BlockTrade5Choice.Proprietary),nameof(BlockTrade5Choice.Proprietary))]
    [IsoId("_5m6BcZNLEeWGlc8L7oPDIg")]
    [DisplayName("Block Trade 5 Choice")]
    public abstract partial record BlockTrade5Choice_
    {
    }
}
