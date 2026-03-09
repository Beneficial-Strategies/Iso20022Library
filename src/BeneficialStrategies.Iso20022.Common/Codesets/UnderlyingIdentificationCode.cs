// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the underlying identification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zm6XAHZVEeWM6LeFwEMTgg")]
[Description(@"Specifies the type of the underlying identification.")]
[Derivations(typeof(UnderlyingIdentification1Code))]
public enum UnderlyingIdentificationCode
{
    /// <summary>
    /// Unknown (not available) underlying identification code.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_7440QHZVEeWM6LeFwEMTgg")]
    [Description(@"Unknown (not available) underlying identification code.")]
    Unknown,
    
    /// <summary>
    /// Basket of indexes identification code.
    /// Encoded/decoded by serializers as &quot;BSKT&quot;.
    /// </summary>
    [EnumMember(Value = "BSKT")]
    [IsoId("_d9ZrYOa4EeW1iL_FRZt8bg")]
    [Description(@"Basket of indexes identification code.")]
    Basket,
    
    /// <summary>
    /// Index identification code.
    /// Encoded/decoded by serializers as &quot;INDX&quot;.
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("_idS-IOa4EeW1iL_FRZt8bg")]
    [Description(@"Index identification code.")]
    Index,
    
}
