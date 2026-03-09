// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external narrative type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MYPEG7iEeKo25nLKvGr8w_2503812")]
[Description(@"Specifies the external narrative type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalNarrativeTypeCode))]
public enum ExternalNarrativeType1Code
{
    /// <summary>
    /// Narrative text describing the additional terms and conditions.
    /// Encoded/decoded by serializers as &quot;ADDI&quot;.
    /// </summary>
    [EnumMember(Value = "ADDI")]
    [IsoId("_uPvIJfRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the additional terms and conditions.")]
    AdditionalTermsAndConditions = ExternalNarrativeTypeCode.AdditionalTermsAndConditions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Narrative text describing the charge details.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_uPvIKPRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the charge details.")]
    ChargeDetails = ExternalNarrativeTypeCode.ChargeDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Narrative text describing the drawing details.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_uP4SEvRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the drawing details.")]
    DrawingDetails = ExternalNarrativeTypeCode.DrawingDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Narrative text describing the assignment of proceeds terms and conditions.
    /// Encoded/decoded by serializers as &quot;PRAS&quot;.
    /// </summary>
    [EnumMember(Value = "PRAS")]
    [IsoId("_uP4SFfRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the assignment of proceeds terms and conditions.")]
    ProceedsAssignable = ExternalNarrativeTypeCode.ProceedsAssignable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Narrative text describing the terms of effectiveness.
    /// Encoded/decoded by serializers as &quot;TEFF&quot;.
    /// </summary>
    [EnumMember(Value = "TEFF")]
    [IsoId("_uP4SGPRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the terms of effectiveness.")]
    TermsOfEffectiveness = ExternalNarrativeTypeCode.TermsOfEffectiveness, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Narrative text describing the transfer terms and conditions.
    /// Encoded/decoded by serializers as &quot;TRNF&quot;.
    /// </summary>
    [EnumMember(Value = "TRNF")]
    [IsoId("_uP4SG_RYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the transfer terms and conditions.")]
    Transfer = ExternalNarrativeTypeCode.Transfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Narrative text describing the terms of variation.
    /// Encoded/decoded by serializers as &quot;TVAR&quot;.
    /// </summary>
    [EnumMember(Value = "TVAR")]
    [IsoId("_uP4SHvRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the terms of variation.")]
    TermsOfVariation = ExternalNarrativeTypeCode.TermsOfVariation, // same ordinal as derivation source for type conversions
    
}
