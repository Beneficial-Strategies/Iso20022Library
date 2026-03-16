// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of an individual.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MJNFcAwTEeiHgJ0O2VQ-kg")]
[Description(@"Identification of an individual.")]
[DerivedFrom(typeof(IdentificationCode))]
public enum Identification2Code
{
    /// <summary>
    /// Driver licence identification.
    /// Encoded/decoded by serializers as &quot;DRID&quot;.
    /// </summary>
    [EnumMember(Value = "DRID")]
    [IsoId("_QK1H0QwTEeiHgJ0O2VQ-kg")]
    [Description(@"Driver licence identification.")]
    DriverLicenceIdentification = IdentificationCode.DriverLicenceIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National identification.
    /// Encoded/decoded by serializers as &quot;NTID&quot;.
    /// </summary>
    [EnumMember(Value = "NTID")]
    [IsoId("_Sxb9sQwTEeiHgJ0O2VQ-kg")]
    [Description(@"National identification.")]
    NationalIdentifier = IdentificationCode.NationalIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Passport number.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_YPMm4QwTEeiHgJ0O2VQ-kg")]
    [Description(@"Passport number.")]
    PassportNumber = IdentificationCode.PassportNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Social security number.
    /// Encoded/decoded by serializers as &quot;SSYN&quot;.
    /// </summary>
    [EnumMember(Value = "SSYN")]
    [IsoId("_Y9AIEQwTEeiHgJ0O2VQ-kg")]
    [Description(@"Social security number.")]
    SocialSecurityNumber = IdentificationCode.SocialSecurityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Alien registration number.
    /// Encoded/decoded by serializers as &quot;ARNB&quot;.
    /// </summary>
    [EnumMember(Value = "ARNB")]
    [IsoId("_alYbIQwTEeiHgJ0O2VQ-kg")]
    [Description(@"Alien registration number.")]
    AlienRegistrationNumber = IdentificationCode.AlienRegistrationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other identification provided at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_R8pjYQwWEeiHgJ0O2VQ-kg")]
    [Description(@"Other identification provided at private level.")]
    OtherPrivate = IdentificationCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other identification assigned at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_SGkUYQwWEeiHgJ0O2VQ-kg")]
    [Description(@"Other identification assigned at national level.")]
    OtherNational = IdentificationCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// E-mail.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_P7TigaetEeiva6IOmhpVHw")]
    [Description(@"E-mail.")]
    Email = IdentificationCode.Email, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Phone number.
    /// Encoded/decoded by serializers as &quot;PHNB&quot;.
    /// </summary>
    [EnumMember(Value = "PHNB")]
    [IsoId("_QOUlIaetEeiva6IOmhpVHw")]
    [Description(@"Phone number.")]
    PhoneNumber = IdentificationCode.PhoneNumber, // same ordinal as derivation source for type conversions
}
