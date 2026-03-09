// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the corporate tax identification type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_tIBiYP4zEeix6ug6HlF6IQ")]
[Description(@"Indicates the corporate tax identification type.")]
[Derivations(typeof(CorporateTaxType1Code))]
public enum CorporateTaxTypeCode
{
    /// <summary>
    /// Corporate
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_tID-oP4zEeix6ug6HlF6IQ")]
    [Description(@"Corporate")]
    Corporate,
    
    /// <summary>
    /// Small Business
    /// Encoded/decoded by serializers as &quot;SMBS&quot;.
    /// </summary>
    [EnumMember(Value = "SMBS")]
    [IsoId("_tICJcv4zEeix6ug6HlF6IQ")]
    [Description(@"Small Business")]
    SmallBusiness,
    
    /// <summary>
    /// Other
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_tICJcP4zEeix6ug6HlF6IQ")]
    [Description(@"Other")]
    Other,
    
}
