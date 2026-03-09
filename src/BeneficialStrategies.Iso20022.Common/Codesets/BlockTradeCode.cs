// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the instruction is the parent or a children of a block trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bU1IQtp-Ed-ak6NoX_4Aeg_-1631812740")]
[Description(@"Specifies whether the instruction is the parent or a children of a block trade.")]
[Derivations(typeof(BlockTrade1Code))]
public enum BlockTradeCode
{
    /// <summary>
    /// Transaction is a block trade parent.
    /// Encoded/decoded by serializers as &quot;BLPA&quot;.
    /// </summary>
    [EnumMember(Value = "BLPA")]
    [IsoId("_bU1IQ9p-Ed-ak6NoX_4Aeg_-1631812715")]
    [Description(@"Transaction is a block trade parent.")]
    Parent,
    
    /// <summary>
    /// Transaction is a block trade child.
    /// Encoded/decoded by serializers as &quot;BLCH&quot;.
    /// </summary>
    [EnumMember(Value = "BLCH")]
    [IsoId("_bU1IRNp-Ed-ak6NoX_4Aeg_-1631812714")]
    [Description(@"Transaction is a block trade child.")]
    Child,
    
}
