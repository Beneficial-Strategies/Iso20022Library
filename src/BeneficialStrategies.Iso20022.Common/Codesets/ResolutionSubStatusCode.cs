// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the sub-status of a resolution.  
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vmscgDUGEe2tRf29bleifQ")]
[Description(@"Specifies the sub-status of a resolution.  ")]
[Derivations(typeof(ResolutionSubStatus1Code))]
public enum ResolutionSubStatusCode
{
    /// <summary>
    /// Resolution voted at the meeting is new. 
    /// Encoded/decoded by serializers as &quot;NEWR&quot;.
    /// </summary>
    [EnumMember(Value = "NEWR")]
    [IsoId("_6ZWt0DUGEe2tRf29bleifQ")]
    [Description(@"Resolution voted at the meeting is new. ")]
    NewResolution,
    
    /// <summary>
    /// Resolution voted at the meeting was amended.
    /// Encoded/decoded by serializers as &quot;AMDR&quot;.
    /// </summary>
    [EnumMember(Value = "AMDR")]
    [IsoId("_EIrS0DUHEe2tRf29bleifQ")]
    [Description(@"Resolution voted at the meeting was amended.")]
    AmendedResolution,
    
}
