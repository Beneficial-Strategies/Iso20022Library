// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the sub-status of a resolution. 
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RMoRUDUHEe2tRf29bleifQ")]
[Description(@"Specifies the sub-status of a resolution. ")]
[DerivedFrom(typeof(ResolutionSubStatusCode))]
public enum ResolutionSubStatus1Code
{
    /// <summary>
    /// Resolution voted at the meeting was amended.
    /// Encoded/decoded by serializers as &quot;AMDR&quot;.
    /// </summary>
    [EnumMember(Value = "AMDR")]
    [IsoId("_Zd6yETUHEe2tRf29bleifQ")]
    [Description(@"Resolution voted at the meeting was amended.")]
    AmendedResolution = ResolutionSubStatusCode.AmendedResolution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Resolution voted at the meeting is new. 
    /// Encoded/decoded by serializers as &quot;NEWR&quot;.
    /// </summary>
    [EnumMember(Value = "NEWR")]
    [IsoId("_ZkxoATUHEe2tRf29bleifQ")]
    [Description(@"Resolution voted at the meeting is new. ")]
    NewResolution = ResolutionSubStatusCode.NewResolution, // same ordinal as derivation source for type conversions
    
}
