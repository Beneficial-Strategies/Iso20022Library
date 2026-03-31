// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Non Precious Metal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FF7T0AnzEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Non Precious Metal.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductType15Code>))]
#endif
public enum AssetClassSubProductType15Code
{
    /// <summary>
    /// Commodity of type non precious metals.
    /// Encoded/decoded by serializers as &quot;NPRM&quot;.
    /// </summary>
    [EnumMember(Value = "NPRM")]
    [IsoId("_lluxkQn0EeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type non precious metals.")]
    NonPrecious = AssetClassSubProductTypeCode.NonPrecious, // same ordinal as derivation source for type conversions
}
