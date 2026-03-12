// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the block trade information.
    /// </summary>
    [KnownType(typeof(BlockTrade4Choice.Code))]
    [KnownType(typeof(BlockTrade4Choice.Proprietary))]
    [JsonDerivedType(typeof(BlockTrade4Choice.Code),nameof(BlockTrade4Choice.Code))]
    [JsonDerivedType(typeof(BlockTrade4Choice.Proprietary),nameof(BlockTrade4Choice.Proprietary))]
    [IsoId("_1_5ugTqHEeWVrPy0StzzSg")]
    [DisplayName("Block Trade 4 Choice")]
    public abstract partial record BlockTrade4Choice_
    {
    }
}
