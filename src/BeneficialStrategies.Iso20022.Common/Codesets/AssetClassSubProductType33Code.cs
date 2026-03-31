// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Construction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yGUxcVrfEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Construction.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductType33Code>))]
#endif
public enum AssetClassSubProductType33Code
{
    /// <summary>
    /// Commodity of type construction.
    /// Encoded/decoded by serializers as &quot;CSTR&quot;.
    /// </summary>
    [EnumMember(Value = "CSTR")]
    [IsoId("_yRs7A1rfEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type construction.")]
    Construction = AssetClassSubProductTypeCode.Construction, // same ordinal as derivation source for type conversions
}
