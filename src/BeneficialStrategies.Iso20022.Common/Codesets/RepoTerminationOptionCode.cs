// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the termination option for a repurchase agreement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tHaf4CyzEea35M2x2c9PXw")]
[Description(@"Indicates the termination option for a repurchase agreement.")]
[Derivations(typeof(RepoTerminationOption1Code),typeof(RepoTerminationOption2Code))]
public enum RepoTerminationOptionCode
{
    /// <summary>
    /// Evergreen termination option.
    /// Encoded/decoded by serializers as &quot;EGRN&quot;.
    /// </summary>
    [EnumMember(Value = "EGRN")]
    [IsoId("_4WluECyzEea35M2x2c9PXw")]
    [Description(@"Evergreen termination option.")]
    Evergreen,
    
    /// <summary>
    /// Extendable termination option.
    /// Encoded/decoded by serializers as &quot;ETSB&quot;.
    /// </summary>
    [EnumMember(Value = "ETSB")]
    [IsoId("_4raukCyzEea35M2x2c9PXw")]
    [Description(@"Extendable termination option.")]
    Extendable,
    
    /// <summary>
    /// Evergreen and extendable termination option. 
    /// Encoded/decoded by serializers as &quot;EGAE&quot;.
    /// </summary>
    [EnumMember(Value = "EGAE")]
    [IsoId("_5AF-ECyzEea35M2x2c9PXw")]
    [Description(@"Evergreen and extendable termination option. ")]
    EvergreenAndExtendable,
    
    /// <summary>
    /// Search for requested data not complete yet.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_vuqPINX_EeiqhpuDZKadPg")]
    [Description(@"Search for requested data not complete yet.")]
    NotApplicable,
    
}
