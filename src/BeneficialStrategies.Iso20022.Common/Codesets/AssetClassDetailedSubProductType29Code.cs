// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Olive Oil.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9VESAbv2EeiLRYqS-r-R-A")]
[Description(@"Further sub product code list for commodity derivative Olive Oil.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum AssetClassDetailedSubProductType29Code
{
    /// <summary>
    /// Commodity attribute of type lampante.
    /// Encoded/decoded by serializers as &quot;LAMP&quot;.
    /// </summary>
    [EnumMember(Value = "LAMP")]
    [IsoId("_9fHl4bv2EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of type lampante.")]
    Lampante = AssetClassDetailedSubProductTypeCode.Lampante, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("__qqQYbv2EeiLRYqS-r-R-A")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
    
}
