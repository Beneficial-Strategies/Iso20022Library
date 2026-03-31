// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Wet.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zzyMMbv6EeiLRYqS-r-R-A")]
[Description(@"Further sub product code list for commodity derivative Wet.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassDetailedSubProductType34Code>))]
#endif
public enum AssetClassDetailedSubProductType34Code
{
    /// <summary>
    /// Commodity attribute of type tanker.
    /// Encoded/decoded by serializers as &quot;TNKR&quot;.
    /// </summary>
    [EnumMember(Value = "TNKR")]
    [IsoId("_0Dk7sbv6EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type tanker.")]
    Tanker = AssetClassDetailedSubProductTypeCode.Tanker, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_2cukYbv6EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
}
