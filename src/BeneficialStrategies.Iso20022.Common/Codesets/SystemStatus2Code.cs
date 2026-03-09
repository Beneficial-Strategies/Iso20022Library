// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZSJe09p-Ed-ak6NoX_4Aeg_-619414979")]
[Description(@"Specifies the status of a system.")]
[DerivedFrom(typeof(SystemStatusCode))]
public enum SystemStatus2Code
{
    /// <summary>
    /// System is suspended, that is, not operational.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_ZSJe1Np-Ed-ak6NoX_4Aeg_-246312211")]
    [Description(@"System is suspended, that is, not operational.")]
    Suspended = SystemStatusCode.Suspended, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// System is functioning normally, that is, operational.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_ZSJe1dp-Ed-ak6NoX_4Aeg_-237078229")]
    [Description(@"System is functioning normally, that is, operational.")]
    Active = SystemStatusCode.Active, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// System is closed (eg. normal closure of an RTGS).
    /// Encoded/decoded by serializers as &quot;CLSD&quot;.
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_ZSJe1tp-Ed-ak6NoX_4Aeg_-234308163")]
    [Description(@"System is closed (eg. normal closure of an RTGS).")]
    Closed = SystemStatusCode.Closed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// System needs to wait for completion of intermediate internal activities before going to a status Closed.
    /// Encoded/decoded by serializers as &quot;CLSG&quot;.
    /// </summary>
    [EnumMember(Value = "CLSG")]
    [IsoId("_ZSJe19p-Ed-ak6NoX_4Aeg_-225070272")]
    [Description(@"System needs to wait for completion of intermediate internal activities before going to a status Closed.")]
    Closing = SystemStatusCode.Closing, // same ordinal as derivation source for type conversions
    
}
