// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code list for agricultural related derivative contracts.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SzFS8M5AEeSc85GUbgBycw")]
[Description(@"Code list for agricultural related derivative contracts.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductAgriculturalType1Code>))]
#endif
public enum AssetClassSubProductAgriculturalType1Code
{
    /// <summary>
    /// Commodity of type dairy.
    /// Encoded/decoded by serializers as &quot;DIRY&quot;.
    /// </summary>
    [EnumMember(Value = "DIRY")]
    [IsoId("_f8pxQc5AEeSc85GUbgBycw")]
    [Description(@"Commodity of type dairy.")]
    Dairy = AssetClassSubProductTypeCode.Dairy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity of type forestry.
    /// Encoded/decoded by serializers as &quot;FRST&quot;.
    /// </summary>
    [EnumMember(Value = "FRST")]
    [IsoId("_gHrVgc5AEeSc85GUbgBycw")]
    [Description(@"Commodity of type forestry.")]
    Forestry = AssetClassSubProductTypeCode.Forestry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity of type grain oil seeds.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_ginlEc5AEeSc85GUbgBycw")]
    [Description(@"Commodity of type grain oil seeds.")]
    GrainOilSeeds = AssetClassSubProductTypeCode.GrainOilSeeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity of type livestock.
    /// Encoded/decoded by serializers as &quot;LSTK&quot;.
    /// </summary>
    [EnumMember(Value = "LSTK")]
    [IsoId("_hBSeEc5AEeSc85GUbgBycw")]
    [Description(@"Commodity of type livestock.")]
    Livestock = AssetClassSubProductTypeCode.Livestock, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity of type softs.
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_pJ0EYc5AEeSc85GUbgBycw")]
    [Description(@"Commodity of type softs.")]
    Softs = AssetClassSubProductTypeCode.Softs, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity of type seafood.
    /// Encoded/decoded by serializers as &quot;SEAF&quot;.
    /// </summary>
    [EnumMember(Value = "SEAF")]
    [IsoId("_iAuhoUDaEeWOL-OsSq2h6w")]
    [Description(@"Commodity of type seafood.")]
    Seafood = AssetClassSubProductTypeCode.Seafood, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_3WT_IUDaEeWOL-OsSq2h6w")]
    [Description(@"Commodity of other type.")]
    Other = AssetClassSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
}
