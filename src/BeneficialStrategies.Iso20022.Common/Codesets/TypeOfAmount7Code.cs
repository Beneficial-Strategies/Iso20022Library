// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type or class of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JO5DMIN-EeSNofOeou9G3A")]
[Description(@"Type or class of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount7Code
{
    /// <summary>
    /// Fees.
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_NBM3MYN-EeSNofOeou9G3A")]
    [Description(@"Fees.")]
    Fees = TypeOfAmountCode.Fees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fees amount from the card issuer.
    /// Encoded/decoded by serializers as &quot;FEEI&quot;.
    /// </summary>
    [EnumMember(Value = "FEEI")]
    [IsoId("_NWACgYN-EeSNofOeou9G3A")]
    [Description(@"Fees amount from the card issuer.")]
    IssuerFees = TypeOfAmountCode.IssuerFees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interchange fees.
    /// Encoded/decoded by serializers as &quot;FEEH&quot;.
    /// </summary>
    [EnumMember(Value = "FEEH")]
    [IsoId("_gi3gAYN-EeSNofOeou9G3A")]
    [Description(@"Interchange fees.")]
    InterchangeFees = TypeOfAmountCode.InterchangeFees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing fees.
    /// Encoded/decoded by serializers as &quot;FEEP&quot;.
    /// </summary>
    [EnumMember(Value = "FEEP")]
    [IsoId("_nk6mcYN-EeSNofOeou9G3A")]
    [Description(@"Processing fees.")]
    ProcessingFees = TypeOfAmountCode.ProcessingFees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// International service assessment fees.
    /// Encoded/decoded by serializers as &quot;FEEA&quot;.
    /// </summary>
    [EnumMember(Value = "FEEA")]
    [IsoId("_63UEMYN-EeSNofOeou9G3A")]
    [Description(@"International service assessment fees.")]
    InternationalServiceAssessmentFees = TypeOfAmountCode.InternationalServiceAssessmentFees, // same ordinal as derivation source for type conversions
}
