// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how information is to be distributed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zDak0CCUEeWJd9HF2tO7BA")]
[Description(@"Specifies how information is to be distributed.")]
[DerivedFrom(typeof(InformationDistributionCode))]
public enum InformationDistribution2Code
{
    /// <summary>
    /// Electronic distribution.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_18fqwSCUEeWJd9HF2tO7BA")]
    [Description(@"Electronic distribution.")]
    Electronic = InformationDistributionCode.Electronic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No distribution.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_2C5NsSCUEeWJd9HF2tO7BA")]
    [Description(@"No distribution.")]
    NoDistribution = InformationDistributionCode.NoDistribution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Paper distribution.
    /// Encoded/decoded by serializers as &quot;PAPR&quot;.
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_2Hpx4SCUEeWJd9HF2tO7BA")]
    [Description(@"Paper distribution.")]
    Paper = InformationDistributionCode.Paper, // same ordinal as derivation source for type conversions
}
