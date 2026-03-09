// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Dry.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ged_Ibv6EeiLRYqS-r-R-A")]
[Description(@"Further sub product code list for commodity derivative Dry.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType33Code
{
    /// <summary>
    /// Commodity attribute of type dry bulk carrier.
    /// Encoded/decoded by serializers as &quot;DBCR&quot;.
    /// </summary>
    [EnumMember(Value = "DBCR")]
    [IsoId("_Gov8gbv6EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type dry bulk carrier.")]
    DryBulkCarrier = AssetClassDetailedSubProductTypeCode.DryBulkCarrier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Ktu04bv6EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
    
}
