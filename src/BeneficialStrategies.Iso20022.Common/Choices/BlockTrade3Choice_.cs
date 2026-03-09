// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the block trade information.
    /// </summary>
    [KnownType(typeof(BlockTrade3Choice.Code))]
    [KnownType(typeof(BlockTrade3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BlockTrade3Choice.Code),nameof(BlockTrade3Choice.Code))]
    [JsonDerivedType(typeof(BlockTrade3Choice.Proprietary),nameof(BlockTrade3Choice.Proprietary))]
    #endif
    [IsoId("_Aa5oxNokEeC60axPepSq7g_-652933311")]
    [DisplayName("Block Trade 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BlockTrade3Choice_
    #else
    public abstract partial class BlockTrade3Choice_
    #endif
    {
    }
}
