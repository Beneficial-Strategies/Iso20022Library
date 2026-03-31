// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Natural Gas.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sJUiQbv3EeiLRYqS-r-R-A")]
[Description(@"Further sub product code list for commodity derivative Natural Gas.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassDetailedSubProductType31Code>))]
#endif
public enum AssetClassDetailedSubProductType31Code
{
    /// <summary>
    /// Commodity attribute of type GASPOOL.
    /// Encoded/decoded by serializers as &quot;GASP&quot;.
    /// </summary>
    [EnumMember(Value = "GASP")]
    [IsoId("_sTWoAbv3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type GASPOOL.")]
    GasPool = AssetClassDetailedSubProductTypeCode.GasPool, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type liquid natural gas.
    /// Encoded/decoded by serializers as &quot;LNGG&quot;.
    /// </summary>
    [EnumMember(Value = "LNGG")]
    [IsoId("_sTWoA7v3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type liquid natural gas.")]
    LNG = AssetClassDetailedSubProductTypeCode.LNG, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type NCG (NetConnect Germany).
    /// Encoded/decoded by serializers as &quot;NCGG&quot;.
    /// </summary>
    [EnumMember(Value = "NCGG")]
    [IsoId("_sTWoBbv3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type NCG (NetConnect Germany).")]
    NCG = AssetClassDetailedSubProductTypeCode.NCG, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type TTF (Dutch Title Transfer Facility).
    /// Encoded/decoded by serializers as &quot;TTFG&quot;.
    /// </summary>
    [EnumMember(Value = "TTFG")]
    [IsoId("_sTWoB7v3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type TTF (Dutch Title Transfer Facility).")]
    TTF = AssetClassDetailedSubProductTypeCode.TTF, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type NBP (National Balancing Point).
    /// Encoded/decoded by serializers as &quot;NBPG&quot;.
    /// </summary>
    [EnumMember(Value = "NBPG")]
    [IsoId("_sTWoCbv3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type NBP (National Balancing Point).")]
    NBP = AssetClassDetailedSubProductTypeCode.NBP, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ubxtEbv3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
}
