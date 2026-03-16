// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Natural Gas.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_89jlYA2eEeW72qLtWESimw")]
[Description(@"Further sub product code list for commodity derivative Natural Gas.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType6Code
{
    /// <summary>
    /// Commodity attribute of type GASPOOL.
    /// Encoded/decoded by serializers as &quot;GASP&quot;.
    /// </summary>
    [EnumMember(Value = "GASP")]
    [IsoId("_2-AL0Q2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type GASPOOL.")]
    GasPool = AssetClassDetailedSubProductTypeCode.GasPool, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type liquid natural gas.
    /// Encoded/decoded by serializers as &quot;LNGG&quot;.
    /// </summary>
    [EnumMember(Value = "LNGG")]
    [IsoId("_3U63AQ2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type liquid natural gas.")]
    LNG = AssetClassDetailedSubProductTypeCode.LNG, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type NCG (NetConnect Germany).
    /// Encoded/decoded by serializers as &quot;NCGG&quot;.
    /// </summary>
    [EnumMember(Value = "NCGG")]
    [IsoId("_4n7-EQ2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type NCG (NetConnect Germany).")]
    NCG = AssetClassDetailedSubProductTypeCode.NCG, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type TTF (Dutch Title Transfer Facility).
    /// Encoded/decoded by serializers as &quot;TTFG&quot;.
    /// </summary>
    [EnumMember(Value = "TTFG")]
    [IsoId("_6EUcgQ2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type TTF (Dutch Title Transfer Facility).")]
    TTF = AssetClassDetailedSubProductTypeCode.TTF, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type NBP (National Balancing Point).
    /// Encoded/decoded by serializers as &quot;NBPG&quot;.
    /// </summary>
    [EnumMember(Value = "NBPG")]
    [IsoId("_rv5EkVrDEeWN79Bl6BUd3g")]
    [Description(@"Commodity attribute of type NBP (National Balancing Point).")]
    NBP = AssetClassDetailedSubProductTypeCode.NBP, // same ordinal as derivation source for type conversions
}
