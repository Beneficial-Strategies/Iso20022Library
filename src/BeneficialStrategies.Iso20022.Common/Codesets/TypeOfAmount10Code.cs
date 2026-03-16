// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type or class of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gDqkkFKOEeeHVODnW-1ONQ")]
[Description(@"Type or class of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount10Code
{
    /// <summary>
    /// Interchange fee.
    /// Encoded/decoded by serializers as &quot;INTC&quot;.
    /// </summary>
    [EnumMember(Value = "INTC")]
    [IsoId("_jvU-AVKOEeeHVODnW-1ONQ")]
    [Description(@"Interchange fee.")]
    InterchangeFee = TypeOfAmountCode.InterchangeFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing fees.
    /// Encoded/decoded by serializers as &quot;FEEP&quot;.
    /// </summary>
    [EnumMember(Value = "FEEP")]
    [IsoId("_oXifQVKOEeeHVODnW-1ONQ")]
    [Description(@"Processing fees.")]
    ProcessingFees = TypeOfAmountCode.ProcessingFees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of amount defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_pN11IVKOEeeHVODnW-1ONQ")]
    [Description(@"Other type of amount defined at national level.")]
    OtherNational = TypeOfAmountCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of amount defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_pR2ycVKOEeeHVODnW-1ONQ")]
    [Description(@"Other type of amount defined at private level.")]
    OtherPrivate = TypeOfAmountCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// International service assessment fees.
    /// Encoded/decoded by serializers as &quot;FEEA&quot;.
    /// </summary>
    [EnumMember(Value = "FEEA")]
    [IsoId("_rf7I4X03Eem0U9m89kippg")]
    [Description(@"International service assessment fees.")]
    InternationalServiceAssessmentFees = TypeOfAmountCode.InternationalServiceAssessmentFees, // same ordinal as derivation source for type conversions
}
