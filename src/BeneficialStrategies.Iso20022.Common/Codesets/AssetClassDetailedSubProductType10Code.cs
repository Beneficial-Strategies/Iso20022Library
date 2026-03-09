// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Non-Precious.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BUgXgA2fEeW72qLtWESimw")]
[Description(@"Further sub product code list for commodity derivative Non-Precious.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType10Code
{
    /// <summary>
    /// Commodity attribute of type aluminium.
    /// Encoded/decoded by serializers as &quot;ALUM&quot;.
    /// </summary>
    [EnumMember(Value = "ALUM")]
    [IsoId("_TEO2sQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type aluminium.")]
    Aluminium = AssetClassDetailedSubProductTypeCode.Aluminium, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type aluminium alloy.
    /// Encoded/decoded by serializers as &quot;ALUA&quot;.
    /// </summary>
    [EnumMember(Value = "ALUA")]
    [IsoId("_TLYAgQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type aluminium alloy.")]
    AluminiumAlloy = AssetClassDetailedSubProductTypeCode.AluminiumAlloy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type cobalt.
    /// Encoded/decoded by serializers as &quot;CBLT&quot;.
    /// </summary>
    [EnumMember(Value = "CBLT")]
    [IsoId("_TtvGsQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type cobalt.")]
    Cobalt = AssetClassDetailedSubProductTypeCode.Cobalt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type copper.
    /// Encoded/decoded by serializers as &quot;COPR&quot;.
    /// </summary>
    [EnumMember(Value = "COPR")]
    [IsoId("_UcwI0Q2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type copper.")]
    Copper = AssetClassDetailedSubProductTypeCode.Copper, // same ordinal as derivation source for type conversions
    
    /// <summary>
    ///  Commodity attribute of type iron ore.
    /// Encoded/decoded by serializers as &quot;IRON&quot;.
    /// </summary>
    [EnumMember(Value = "IRON")]
    [IsoId("_XdkOcQ2hEeW72qLtWESimw")]
    [Description(@" Commodity attribute of type iron ore.")]
    IronOre = AssetClassDetailedSubProductTypeCode.IronOre, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type molybdenum.
    /// Encoded/decoded by serializers as &quot;MOLY&quot;.
    /// </summary>
    [EnumMember(Value = "MOLY")]
    [IsoId("_YP_w8Q2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type molybdenum.")]
    Molybdenum = AssetClassDetailedSubProductTypeCode.Molybdenum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type NASAAC (North American Special Aluminum Alloy Contract).
    /// Encoded/decoded by serializers as &quot;NASC&quot;.
    /// </summary>
    [EnumMember(Value = "NASC")]
    [IsoId("_b7pjUQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type NASAAC (North American Special Aluminum Alloy Contract).")]
    NASAAC = AssetClassDetailedSubProductTypeCode.NASAAC, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type nickel.
    /// Encoded/decoded by serializers as &quot;NICK&quot;.
    /// </summary>
    [EnumMember(Value = "NICK")]
    [IsoId("_cfgeUQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type nickel.")]
    Nickel = AssetClassDetailedSubProductTypeCode.Nickel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type steel.
    /// Encoded/decoded by serializers as &quot;STEL&quot;.
    /// </summary>
    [EnumMember(Value = "STEL")]
    [IsoId("_fS7oMQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type steel.")]
    Steel = AssetClassDetailedSubProductTypeCode.Steel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type tin.
    /// Encoded/decoded by serializers as &quot;TINN&quot;.
    /// </summary>
    [EnumMember(Value = "TINN")]
    [IsoId("_gj3EkQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type tin.")]
    Tin = AssetClassDetailedSubProductTypeCode.Tin, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type zinc.
    /// Encoded/decoded by serializers as &quot;ZINC&quot;.
    /// </summary>
    [EnumMember(Value = "ZINC")]
    [IsoId("_h6mOAQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type zinc.")]
    Zinc = AssetClassDetailedSubProductTypeCode.Zinc, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_jKfIkQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type lead.
    /// Encoded/decoded by serializers as &quot;LEAD&quot;.
    /// </summary>
    [EnumMember(Value = "LEAD")]
    [IsoId("_j32xUVrDEeWN79Bl6BUd3g")]
    [Description(@"Commodity attribute of type lead.")]
    Lead = AssetClassDetailedSubProductTypeCode.Lead, // same ordinal as derivation source for type conversions
    
}
