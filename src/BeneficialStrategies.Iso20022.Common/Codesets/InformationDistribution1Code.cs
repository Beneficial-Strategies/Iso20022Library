// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how information is to be distributed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_azNaYBOCEeKjmvxNCObNeQ")]
[Description(@"Specifies how information is to be distributed.")]
[DerivedFrom(typeof(InformationDistributionCode))]
public enum InformationDistribution1Code
{
    /// <summary>
    /// Electronic distribution.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_jzUI8ROCEeKjmvxNCObNeQ")]
    [Description(@"Electronic distribution.")]
    Electronic = InformationDistributionCode.Electronic, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Paper distribution.
    /// Encoded/decoded by serializers as &quot;PAPR&quot;.
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_j7gboROCEeKjmvxNCObNeQ")]
    [Description(@"Paper distribution.")]
    Paper = InformationDistributionCode.Paper, // same ordinal as derivation source for type conversions
    
}
