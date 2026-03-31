// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the instruction is the parent or a children of a block trade.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_begotNp-Ed-ak6NoX_4Aeg_450632861")]
[Description(@"Specifies whether the instruction is the parent or a children of a block trade.")]
[DerivedFrom(typeof(BlockTradeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BlockTrade1Code>))]
#endif
public enum BlockTrade1Code
{
    /// <summary>
    /// Transaction is a block trade parent.
    /// Encoded/decoded by serializers as &quot;BLPA&quot;.
    /// </summary>
    [EnumMember(Value = "BLPA")]
    [IsoId("_begotdp-Ed-ak6NoX_4Aeg_489423628")]
    [Description(@"Transaction is a block trade parent.")]
    Parent = BlockTradeCode.Parent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a block trade child.
    /// Encoded/decoded by serializers as &quot;BLCH&quot;.
    /// </summary>
    [EnumMember(Value = "BLCH")]
    [IsoId("_begottp-Ed-ak6NoX_4Aeg_535598920")]
    [Description(@"Transaction is a block trade child.")]
    Child = BlockTradeCode.Child, // same ordinal as derivation source for type conversions
}
