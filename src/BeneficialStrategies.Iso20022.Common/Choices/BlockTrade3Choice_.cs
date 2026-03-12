// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the block trade information.
    /// </summary>
    [KnownType(typeof(BlockTrade3Choice.Code))]
    [KnownType(typeof(BlockTrade3Choice.Proprietary))]
    [JsonDerivedType(typeof(BlockTrade3Choice.Code),nameof(BlockTrade3Choice.Code))]
    [JsonDerivedType(typeof(BlockTrade3Choice.Proprietary),nameof(BlockTrade3Choice.Proprietary))]
    [IsoId("_Aa5oxNokEeC60axPepSq7g_-652933311")]
    [DisplayName("Block Trade 3 Choice")]
    public abstract partial record BlockTrade3Choice_
    {
    }
}
