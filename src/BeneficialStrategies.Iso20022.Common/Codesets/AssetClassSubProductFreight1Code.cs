// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code list for freight related derivative contracts.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kHVf0NDvEeS8V88MH4oPOQ")]
[Description(@"Code list for freight related derivative contracts.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductFreight1Code>))]
#endif
public enum AssetClassSubProductFreight1Code
{
    /// <summary>
    /// Commodity of type dry freight.
    /// Encoded/decoded by serializers as &quot;DRYF&quot;.
    /// </summary>
    [EnumMember(Value = "DRYF")]
    [IsoId("_pxgg4UDbEeWOL-OsSq2h6w")]
    [Description(@"Commodity of type dry freight.")]
    Dry = AssetClassSubProductTypeCode.Dry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity of type wet freight.
    /// Encoded/decoded by serializers as &quot;WETF&quot;.
    /// </summary>
    [EnumMember(Value = "WETF")]
    [IsoId("_q4LOAUDbEeWOL-OsSq2h6w")]
    [Description(@"Commodity of type wet freight.")]
    Wet = AssetClassSubProductTypeCode.Wet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_mmQ5MafvEeW_OId9wS8dsQ")]
    [Description(@"Commodity of other type.")]
    Other = AssetClassSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
}
