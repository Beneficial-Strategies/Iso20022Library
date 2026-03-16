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
[IsoId("_-MYPEW7iEeKo25nLKvGr8w_931495915")]
[Description(
    @"Specifies the external narrative type code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalNarrativeType1Code))]
public enum ExternalNarrativeTypeCode
{
    /// <summary>
    /// Narrative text describing the additional terms and conditions.
    /// Encoded/decoded by serializers as &quot;ADDI&quot;.
    /// </summary>
    [EnumMember(Value = "ADDI")]
    [IsoId("_uPvII_RYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the additional terms and conditions.")]
    AdditionalTermsAndConditions,

    /// <summary>
    /// Narrative text describing the charge details.
    /// Encoded/decoded by serializers as &quot;CHAR&quot;.
    /// </summary>
    [EnumMember(Value = "CHAR")]
    [IsoId("_uPvIJvRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the charge details.")]
    ChargeDetails,

    /// <summary>
    /// Narrative text describing the drawing details.
    /// Encoded/decoded by serializers as &quot;DRAW&quot;.
    /// </summary>
    [EnumMember(Value = "DRAW")]
    [IsoId("_uP4SEPRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the drawing details.")]
    DrawingDetails,

    /// <summary>
    /// Narrative text describing the assignment of proceeds terms and conditions.
    /// Encoded/decoded by serializers as &quot;PRAS&quot;.
    /// </summary>
    [EnumMember(Value = "PRAS")]
    [IsoId("_uP4SE_RYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the assignment of proceeds terms and conditions.")]
    ProceedsAssignable,

    /// <summary>
    /// Narrative text describing the terms of effectiveness.
    /// Encoded/decoded by serializers as &quot;TEFF&quot;.
    /// </summary>
    [EnumMember(Value = "TEFF")]
    [IsoId("_uP4SFvRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the terms of effectiveness.")]
    TermsOfEffectiveness,

    /// <summary>
    /// Narrative text describing the transfer terms and conditions.
    /// Encoded/decoded by serializers as &quot;TRNF&quot;.
    /// </summary>
    [EnumMember(Value = "TRNF")]
    [IsoId("_uP4SGfRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the transfer terms and conditions.")]
    Transfer,

    /// <summary>
    /// Narrative text describing the terms of variation.
    /// Encoded/decoded by serializers as &quot;TVAR&quot;.
    /// </summary>
    [EnumMember(Value = "TVAR")]
    [IsoId("_uP4SHPRYEeuLhpyIdtJzwg")]
    [Description(@"Narrative text describing the terms of variation.")]
    TermsOfVariation,
}
