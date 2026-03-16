// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of tax reference.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_A351sE4REeiQHa-q1Uephw")]
[Description(@"Specifies a type of tax reference.")]
[DerivedFrom(typeof(PersonIdentificationTypeCode))]
public enum PersonIdentificationType7Code
{
    /// <summary>
    /// Temporary tax processing number (used in the domestic adoption of a child).
    /// Encoded/decoded by serializers as &quot;ATIN&quot;.
    /// </summary>
    [EnumMember(Value = "ATIN")]
    [IsoId("_CZgLUU4REeiQHa-q1Uephw")]
    [Description(@"Temporary tax processing number (used in the domestic adoption of a child).")]
    AdoptionTaxpayerIdentificationNumber =
        PersonIdentificationTypeCode.AdoptionTaxpayerIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Generic tax identification number.
    /// Encoded/decoded by serializers as &quot;GTIN&quot;.
    /// </summary>
    [EnumMember(Value = "GTIN")]
    [IsoId("_C_cJ8U4REeiQHa-q1Uephw")]
    [Description(@"Generic tax identification number.")]
    GenericTaxIdentificationNumber = PersonIdentificationTypeCode.GenericTaxIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax processing number.
    /// Encoded/decoded by serializers as &quot;ITIN&quot;.
    /// </summary>
    [EnumMember(Value = "ITIN")]
    [IsoId("_D1vf0U4REeiQHa-q1Uephw")]
    [Description(@"Tax processing number.")]
    IndividualTaxpayerIdentificationNumber =
        PersonIdentificationTypeCode.IndividualTaxpayerIdentificationNumber, // same ordinal as derivation source for type conversions
}
