// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specific TR34 status that the ATM could use.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ke5GkLTiEeeQy4o2AayYHg")]
[Description(@"Specific TR34 status that the ATM could use.")]
[Derivations(typeof(TR34Status1Code))]
public enum TR34StatusCode
{
    /// <summary>
    /// The device is bound.
    /// Encoded/decoded by serializers as &quot;BUND&quot;.
    /// </summary>
    [EnumMember(Value = "BUND")]
    [IsoId("_uee8MLTiEeeQy4o2AayYHg")]
    [Description(@"The device is bound.")]
    Bound,
    
    /// <summary>
    /// The device is unbound.
    /// Encoded/decoded by serializers as &quot;UBND&quot;.
    /// </summary>
    [EnumMember(Value = "UBND")]
    [IsoId("_1_-XsLTiEeeQy4o2AayYHg")]
    [Description(@"The device is unbound.")]
    Unbound,
    
}
