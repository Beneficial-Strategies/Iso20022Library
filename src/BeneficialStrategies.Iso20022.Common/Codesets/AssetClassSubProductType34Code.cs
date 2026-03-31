// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Manufacturing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zvbdQVrfEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Manufacturing.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductType34Code>))]
#endif
public enum AssetClassSubProductType34Code
{
    /// <summary>
    /// Commodity of type manufacturing.
    /// Encoded/decoded by serializers as &quot;MFTG&quot;.
    /// </summary>
    [EnumMember(Value = "MFTG")]
    [IsoId("_z68wwVrfEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type manufacturing.")]
    Manufacturing = AssetClassSubProductTypeCode.Manufacturing, // same ordinal as derivation source for type conversions
}
