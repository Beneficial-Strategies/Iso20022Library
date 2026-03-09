// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a restriction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_h5LIgCFnEeW9XJWqfgXIIA")]
[Description(@"Specifies the status of a restriction.")]
[Derivations(typeof(RestrictionStatus1Code))]
public enum RestrictionStatusCode
{
    /// <summary>
    /// Status of the restriction is inactive.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_m71xICFnEeW9XJWqfgXIIA")]
    [Description(@"Status of the restriction is inactive.")]
    Inactive,
    
    /// <summary>
    /// Status of the restriction is active.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_q6q-MCFnEeW9XJWqfgXIIA")]
    [Description(@"Status of the restriction is active.")]
    Active,
    
}
