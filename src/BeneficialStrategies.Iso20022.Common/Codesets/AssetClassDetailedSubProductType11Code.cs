// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Precious.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CaRswA2fEeW72qLtWESimw")]
[Description(@"Further sub product code list for commodity derivative Precious.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType11Code
{
    /// <summary>
    /// Commodity attribute of type gold.
    /// Encoded/decoded by serializers as &quot;GOLD&quot;.
    /// </summary>
    [EnumMember(Value = "GOLD")]
    [IsoId("_lDcOQQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type gold.")]
    Gold = AssetClassDetailedSubProductTypeCode.Gold, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_mf1TwQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type palladium.
    /// Encoded/decoded by serializers as &quot;PLDM&quot;.
    /// </summary>
    [EnumMember(Value = "PLDM")]
    [IsoId("_mnaicQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type palladium.")]
    Palladium = AssetClassDetailedSubProductTypeCode.Palladium, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type platinum.
    /// Encoded/decoded by serializers as &quot;PTNM&quot;.
    /// </summary>
    [EnumMember(Value = "PTNM")]
    [IsoId("_my3kgQ2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type platinum.")]
    Platinum = AssetClassDetailedSubProductTypeCode.Platinum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of type silver.
    /// Encoded/decoded by serializers as &quot;SLVR&quot;.
    /// </summary>
    [EnumMember(Value = "SLVR")]
    [IsoId("_naSw4Q2hEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type silver.")]
    Silver = AssetClassDetailedSubProductTypeCode.Silver, // same ordinal as derivation source for type conversions
    
}
