// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Grain.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TcElYbv3EeiLRYqS-r-R-A")]
[Description(@"Further sub product code list for commodity derivative Grain.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType30Code
{
    /// <summary>
    /// Commodity attribute of type milled wheat.
    /// Encoded/decoded by serializers as &quot;MWHT&quot;.
    /// </summary>
    [EnumMember(Value = "MWHT")]
    [IsoId("_Tlws4bv3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type milled wheat.")]
    MillingWheat = AssetClassDetailedSubProductTypeCode.MillingWheat, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VhCGwbv3EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
    
}
