// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the packaging type as published in an external packaging type code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JdeN8PeZEee0h5ZXun0VTA")]
[Description(@"Specifies the packaging type as published in an external packaging type code list.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalPackagingType1Code))]
public enum ExternalPackagingTypeCode
{
    /// <summary>
    /// Packaging is high density polyethylene.
    /// Encoded/decoded by serializers as &quot;HDPE&quot;.
    /// </summary>
    [EnumMember(Value = "HDPE")]
    [IsoId("_uIlXSfRYEeuLhpyIdtJzwg")]
    [Description(@"Packaging is high density polyethylene.")]
    HighDensityPolyethylene,
    
    /// <summary>
    /// Packaging is low density polyethylene.
    /// Encoded/decoded by serializers as &quot;LDPE&quot;.
    /// </summary>
    [EnumMember(Value = "LDPE")]
    [IsoId("_uIlXTPRYEeuLhpyIdtJzwg")]
    [Description(@"Packaging is low density polyethylene.")]
    LowDensityPolyethylene,
    
    /// <summary>
    /// Packaging is linear low density polyethylene.
    /// Encoded/decoded by serializers as &quot;LLDP&quot;.
    /// </summary>
    [EnumMember(Value = "LLDP")]
    [IsoId("_uIvIQPRYEeuLhpyIdtJzwg")]
    [Description(@"Packaging is linear low density polyethylene.")]
    LinearLowDensityPolyethylene,
    
    /// <summary>
    /// Other packaging type not otherwise specified.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_uIvIQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Other packaging type not otherwise specified.")]
    OtherPackagingType,
    
}
