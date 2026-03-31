// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Other.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_asQDwVrLEeWN79Bl6BUd3g")]
[Description(@"Commodity derivative base product code list for Other.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassProductType15Code>))]
#endif
public enum AssetClassProductType15Code
{
    /// <summary>
    /// Commodity of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_a3iGs1rLEeWN79Bl6BUd3g")]
    [Description(@"Commodity of other type.")]
    Other = AssetClassProductTypeCode.Other, // same ordinal as derivation source for type conversions
}
