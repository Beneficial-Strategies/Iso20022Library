// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Urea.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_o_RZcVr3EeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Urea.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductType43Code>))]
#endif
public enum AssetClassSubProductType43Code
{
    /// <summary>
    /// Commodity of type urea.
    /// Encoded/decoded by serializers as &quot;UREA&quot;.
    /// </summary>
    [EnumMember(Value = "UREA")]
    [IsoId("_pK4MiVr3EeWN79Bl6BUd3g")]
    [Description(@"Commodity of type urea.")]
    Urea = AssetClassSubProductTypeCode.Urea, // same ordinal as derivation source for type conversions
}
