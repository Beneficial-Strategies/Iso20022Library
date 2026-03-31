// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the allowed foreign exchange types for foreign exchange derivatives.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IWuWENDjEeSv_Pll20DdbA")]
[Description(@"Specifies the allowed foreign exchange types for foreign exchange derivatives.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetFXSubProductType1Code>))]
#endif
public enum AssetFXSubProductType1Code
{
    /// <summary>
    /// Commodity attribute of type foreign exchange cross rate.
    /// Encoded/decoded by serializers as &quot;FXCR&quot;.
    /// </summary>
    [EnumMember(Value = "FXCR")]
    [IsoId("_LWWI4dDjEeSv_Pll20DdbA")]
    [Description(@"Commodity attribute of type foreign exchange cross rate.")]
    ForeignExchangeCrossRate = AssetClassDetailedSubProductTypeCode.ForeignExchangeCrossRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type foreign exchange emerging markets.
    /// Encoded/decoded by serializers as &quot;FXEM&quot;.
    /// </summary>
    [EnumMember(Value = "FXEM")]
    [IsoId("_LeFIkdDjEeSv_Pll20DdbA")]
    [Description(@"Commodity attribute of type foreign exchange emerging markets.")]
    ForeignExchangeEmergingMarket =
        AssetClassDetailedSubProductTypeCode.ForeignExchangeEmergingMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type foreign exchange majors.
    /// Encoded/decoded by serializers as &quot;FXMJ&quot;.
    /// </summary>
    [EnumMember(Value = "FXMJ")]
    [IsoId("_Lj4OkdDjEeSv_Pll20DdbA")]
    [Description(@"Commodity attribute of type foreign exchange majors.")]
    ForeignExchangeMajor = AssetClassDetailedSubProductTypeCode.ForeignExchangeMajor, // same ordinal as derivation source for type conversions
}
