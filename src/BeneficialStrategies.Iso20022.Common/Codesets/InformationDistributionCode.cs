// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how information is to be distributed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-jTPExOBEeKjmvxNCObNeQ")]
[Description(@"Specifies how information is to be distributed.")]
[Derivations(typeof(InformationDistribution1Code), typeof(InformationDistribution2Code))]
public enum InformationDistributionCode
{
    /// <summary>
    /// Paper distribution.
    /// Encoded/decoded by serializers as &quot;PAPR&quot;.
    /// </summary>
    [EnumMember(Value = "PAPR")]
    [IsoId("_LZJgIBOCEeKjmvxNCObNeQ")]
    [Description(@"Paper distribution.")]
    Paper,

    /// <summary>
    /// Electronic distribution.
    /// Encoded/decoded by serializers as &quot;ELEC&quot;.
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_LjIikBOCEeKjmvxNCObNeQ")]
    [Description(@"Electronic distribution.")]
    Electronic,

    /// <summary>
    /// No distribution.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_s8JEkCCUEeWJd9HF2tO7BA")]
    [Description(@"No distribution.")]
    NoDistribution,
}
