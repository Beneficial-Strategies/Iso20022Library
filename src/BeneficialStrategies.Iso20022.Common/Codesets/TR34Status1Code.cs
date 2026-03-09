// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specific TR34 status that the ATM could use.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_HB6OsLTjEeeQy4o2AayYHg")]
[Description(@"Specific TR34 status that the ATM could use.")]
[DerivedFrom(typeof(TR34StatusCode))]
public enum TR34Status1Code
{
    /// <summary>
    /// The device is bound.
    /// Encoded/decoded by serializers as &quot;BUND&quot;.
    /// </summary>
    [EnumMember(Value = "BUND")]
    [IsoId("_MpMAQbTjEeeQy4o2AayYHg")]
    [Description(@"The device is bound.")]
    Bound = TR34StatusCode.Bound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The device is unbound.
    /// Encoded/decoded by serializers as &quot;UBND&quot;.
    /// </summary>
    [EnumMember(Value = "UBND")]
    [IsoId("_MtU5YbTjEeeQy4o2AayYHg")]
    [Description(@"The device is unbound.")]
    Unbound = TR34StatusCode.Unbound, // same ordinal as derivation source for type conversions
    
}
