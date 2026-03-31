// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Light Ends.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_omSLIVrKEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Light Ends.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductType27Code>))]
#endif
public enum AssetClassSubProductType27Code
{
    /// <summary>
    /// Commodity of type light ends.
    /// Encoded/decoded by serializers as &quot;LGHT&quot;.
    /// </summary>
    [EnumMember(Value = "LGHT")]
    [IsoId("_oxn4d1rKEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type light ends.")]
    LightEnds = AssetClassSubProductTypeCode.LightEnds, // same ordinal as derivation source for type conversions
}
