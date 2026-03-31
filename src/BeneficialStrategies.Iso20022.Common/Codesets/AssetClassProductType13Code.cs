// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Multi Commodity Exotic.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XnIF4VrLEeWN79Bl6BUd3g")]
[Description(@"Commodity derivative base product code list for Multi Commodity Exotic.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassProductType13Code>))]
#endif
public enum AssetClassProductType13Code
{
    /// <summary>
    /// Commodity of type multi commodity exotic.
    /// Encoded/decoded by serializers as &quot;MCEX&quot;.
    /// </summary>
    [EnumMember(Value = "MCEX")]
    [IsoId("_XyXFgVrLEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type multi commodity exotic.")]
    MultiCommodityExotic = AssetClassProductTypeCode.MultiCommodityExotic, // same ordinal as derivation source for type conversions
}
