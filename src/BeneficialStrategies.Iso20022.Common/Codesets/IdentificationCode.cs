// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code to identify an individual.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3AoIYMV1Eee3gsS0IxDWIA")]
[Description(@"Code to identify an individual.")]
[Derivations(typeof(Identification2Code), typeof(Identification3Code))]
public enum IdentificationCode
{
    /// <summary>
    /// Identification of customer.
    /// Encoded/decoded by serializers as &quot;CUID&quot;.
    /// </summary>
    [EnumMember(Value = "CUID")]
    [IsoId("_6jmf4MV1Eee3gsS0IxDWIA")]
    [Description(@"Identification of customer.")]
    CustomerIdentification,

    /// <summary>
    /// Social security number.
    /// Encoded/decoded by serializers as &quot;SSYN&quot;.
    /// </summary>
    [EnumMember(Value = "SSYN")]
    [IsoId("_BbQUMMV2Eee3gsS0IxDWIA")]
    [Description(@"Social security number.")]
    SocialSecurityNumber,

    /// <summary>
    /// National identification.
    /// Encoded/decoded by serializers as &quot;NTID&quot;.
    /// </summary>
    [EnumMember(Value = "NTID")]
    [IsoId("_HaG4QMV2Eee3gsS0IxDWIA")]
    [Description(@"National identification.")]
    NationalIdentifier,

    /// <summary>
    /// Country issuing national identifier.
    /// Encoded/decoded by serializers as &quot;NICY&quot;.
    /// </summary>
    [EnumMember(Value = "NICY")]
    [IsoId("_MYuuYMV2Eee3gsS0IxDWIA")]
    [Description(@"Country issuing national identifier.")]
    NationalIdentifierCountry,

    /// <summary>
    /// Passport number.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_Wrq90MV2Eee3gsS0IxDWIA")]
    [Description(@"Passport number.")]
    PassportNumber,

    /// <summary>
    /// Country issuing passport.
    /// Encoded/decoded by serializers as &quot;PAIC&quot;.
    /// </summary>
    [EnumMember(Value = "PAIC")]
    [IsoId("_fAcQYMV2Eee3gsS0IxDWIA")]
    [Description(@"Country issuing passport.")]
    PassportIssuingCountry,

    /// <summary>
    /// Driver licence identification.
    /// Encoded/decoded by serializers as &quot;DRID&quot;.
    /// </summary>
    [EnumMember(Value = "DRID")]
    [IsoId("_pIFOwMV2Eee3gsS0IxDWIA")]
    [Description(@"Driver licence identification.")]
    DriverLicenceIdentification,

    /// <summary>
    /// Country issuing driver licence.
    /// Encoded/decoded by serializers as &quot;DRIC&quot;.
    /// </summary>
    [EnumMember(Value = "DRIC")]
    [IsoId("_wJVrAMV2Eee3gsS0IxDWIA")]
    [Description(@"Country issuing driver licence.")]
    DriverLicenceIssuingCountry,

    /// <summary>
    /// Employee identification.
    /// Encoded/decoded by serializers as &quot;EEID&quot;.
    /// </summary>
    [EnumMember(Value = "EEID")]
    [IsoId("_2WqI4MV2Eee3gsS0IxDWIA")]
    [Description(@"Employee identification.")]
    EmployeeIdentification,

    /// <summary>
    /// Employer identification.
    /// Encoded/decoded by serializers as &quot;ERID&quot;.
    /// </summary>
    [EnumMember(Value = "ERID")]
    [IsoId("_6-a-MMV2Eee3gsS0IxDWIA")]
    [Description(@"Employer identification.")]
    EmployerIdentification,

    /// <summary>
    /// Job number.
    /// Encoded/decoded by serializers as &quot;JBNR&quot;.
    /// </summary>
    [EnumMember(Value = "JBNR")]
    [IsoId("_Akw7oMV3Eee3gsS0IxDWIA")]
    [Description(@"Job number.")]
    JobNumber,

    /// <summary>
    /// Department.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_F96xoMV3Eee3gsS0IxDWIA")]
    [Description(@"Department.")]
    Department,

    /// <summary>
    /// Alien registration number.
    /// Encoded/decoded by serializers as &quot;ARNB&quot;.
    /// </summary>
    [EnumMember(Value = "ARNB")]
    [IsoId("_IXuhoMV3Eee3gsS0IxDWIA")]
    [Description(@"Alien registration number.")]
    AlienRegistrationNumber,

    /// <summary>
    /// Tax identifier.
    /// Encoded/decoded by serializers as &quot;TXID&quot;.
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("_NZ-TgMV3Eee3gsS0IxDWIA")]
    [Description(@"Tax identifier.")]
    TaxIdentifier,

    /// <summary>
    /// Tax country.
    /// Encoded/decoded by serializers as &quot;TXCY&quot;.
    /// </summary>
    [EnumMember(Value = "TXCY")]
    [IsoId("_SQ93oMV3Eee3gsS0IxDWIA")]
    [Description(@"Tax country.")]
    TaxCountry,

    /// <summary>
    /// Date and place of birth.
    /// Encoded/decoded by serializers as &quot;DTPB&quot;.
    /// </summary>
    [EnumMember(Value = "DTPB")]
    [IsoId("_WjZ9MMV3Eee3gsS0IxDWIA")]
    [Description(@"Date and place of birth.")]
    DateAndPlaceOfBirth,

    /// <summary>
    /// E-mail.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_e9HaIMV3Eee3gsS0IxDWIA")]
    [Description(@"E-mail.")]
    Email,

    /// <summary>
    /// Phone number.
    /// Encoded/decoded by serializers as &quot;PHNB&quot;.
    /// </summary>
    [EnumMember(Value = "PHNB")]
    [IsoId("_ltjzMMV3Eee3gsS0IxDWIA")]
    [Description(@"Phone number.")]
    PhoneNumber,

    /// <summary>
    /// Other identification assigned at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_B8kK8AwWEeiHgJ0O2VQ-kg")]
    [Description(@"Other identification assigned at national level.")]
    OtherNational,

    /// <summary>
    /// Other identification provided at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_IZRIoAwWEeiHgJ0O2VQ-kg")]
    [Description(@"Other identification provided at private level.")]
    OtherPrivate,

    /// <summary>
    /// Proxy
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_NxyZIKd3EeuEcqP2FGAFaA")]
    [Description(@"Proxy")]
    Proxy,
}
