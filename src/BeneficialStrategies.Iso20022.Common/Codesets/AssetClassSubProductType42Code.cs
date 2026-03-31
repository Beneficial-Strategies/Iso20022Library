// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Sulphur.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jJQoUVr3EeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Sulphur.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductType42Code>))]
#endif
public enum AssetClassSubProductType42Code
{
    /// <summary>
    /// Commodity of type sulphur.
    /// Encoded/decoded by serializers as &quot;SLPH&quot;.
    /// </summary>
    [EnumMember(Value = "SLPH")]
    [IsoId("_jVdRR1r3EeWN79Bl6BUd3g")]
    [Description(@"Commodity of type sulphur.")]
    Sulphur = AssetClassSubProductTypeCode.Sulphur, // same ordinal as derivation source for type conversions
}
