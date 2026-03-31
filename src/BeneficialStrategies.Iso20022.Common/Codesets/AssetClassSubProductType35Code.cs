// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Containerboard.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ml0BAVryEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Containerboard.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductType35Code>))]
#endif
public enum AssetClassSubProductType35Code
{
    /// <summary>
    /// Commodity of type containerboard.
    /// Encoded/decoded by serializers as &quot;CBRD&quot;.
    /// </summary>
    [EnumMember(Value = "CBRD")]
    [IsoId("_mxGD8VryEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type containerboard.")]
    Containerboard = AssetClassSubProductTypeCode.Containerboard, // same ordinal as derivation source for type conversions
}
