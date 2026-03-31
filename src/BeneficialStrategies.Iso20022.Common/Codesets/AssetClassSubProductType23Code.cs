// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Seafood.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0UwTgVrBEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Seafood.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductType23Code>))]
#endif
public enum AssetClassSubProductType23Code
{
    /// <summary>
    /// Commodity of type seafood.
    /// Encoded/decoded by serializers as &quot;SEAF&quot;.
    /// </summary>
    [EnumMember(Value = "SEAF")]
    [IsoId("_0hERMVrBEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type seafood.")]
    Seafood = AssetClassSubProductTypeCode.Seafood, // same ordinal as derivation source for type conversions
}
