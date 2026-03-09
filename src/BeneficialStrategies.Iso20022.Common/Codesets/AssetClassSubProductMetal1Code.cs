// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code list for metal related derivative contracts.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Wi3yENDrEeS8V88MH4oPOQ")]
[Description(@"Code list for metal related derivative contracts.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductMetal1Code
{
    /// <summary>
    /// Commodity of type non precious metals.
    /// Encoded/decoded by serializers as &quot;NPRM&quot;.
    /// </summary>
    [EnumMember(Value = "NPRM")]
    [IsoId("_aFAcEdDrEeS8V88MH4oPOQ")]
    [Description(@"Commodity of type non precious metals.")]
    NonPrecious = AssetClassSubProductTypeCode.NonPrecious, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity of type precious metals.
    /// Encoded/decoded by serializers as &quot;PRME&quot;.
    /// </summary>
    [EnumMember(Value = "PRME")]
    [IsoId("_aSQN4dDrEeS8V88MH4oPOQ")]
    [Description(@"Commodity of type precious metals.")]
    Precious = AssetClassSubProductTypeCode.Precious, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commodity of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_IOVEkAFLEeaDfK-zDSyB6A")]
    [Description(@"Commodity of other type.")]
    Other = AssetClassSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
    
}
