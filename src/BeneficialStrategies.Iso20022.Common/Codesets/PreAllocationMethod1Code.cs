// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the method of preallocation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aH73Vdp-Ed-ak6NoX_4Aeg_1192284637")]
[Description(@"Indicates the method of preallocation.")]
[DerivedFrom(typeof(PreAllocationMethodCode))]
public enum PreAllocationMethod1Code
{
    /// <summary>
    /// Preallocation is proratised.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_aH73Vtp-Ed-ak6NoX_4Aeg_1246774126")]
    [Description(@"Preallocation is proratised.")]
    Prorata = PreAllocationMethodCode.Prorata, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No prorata, discuss first.
    /// Encoded/decoded by serializers as &quot;TALK&quot;.
    /// </summary>
    [EnumMember(Value = "TALK")]
    [IsoId("_aH73V9p-Ed-ak6NoX_4Aeg_1246774161")]
    [Description(@"No prorata, discuss first.")]
    SpeakFirst = PreAllocationMethodCode.SpeakFirst, // same ordinal as derivation source for type conversions
    
}
