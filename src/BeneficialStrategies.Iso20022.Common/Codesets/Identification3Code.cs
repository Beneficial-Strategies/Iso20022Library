// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of an individual.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_leEoQad3EeuEcqP2FGAFaA")]
[Description(@"Identification of an individual.")]
[DerivedFrom(typeof(IdentificationCode))]
public enum Identification3Code
{
    /// <summary>
    /// Driver licence identification.
    /// Encoded/decoded by serializers as &quot;DRID&quot;.
    /// </summary>
    [EnumMember(Value = "DRID")]
    [IsoId("_ljyOsad3EeuEcqP2FGAFaA")]
    [Description(@"Driver licence identification.")]
    DriverLicenceIdentification = IdentificationCode.DriverLicenceIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National identification.
    /// Encoded/decoded by serializers as &quot;NTID&quot;.
    /// </summary>
    [EnumMember(Value = "NTID")]
    [IsoId("_ljyOs6d3EeuEcqP2FGAFaA")]
    [Description(@"National identification.")]
    NationalIdentifier = IdentificationCode.NationalIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Passport number.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_ljyOtad3EeuEcqP2FGAFaA")]
    [Description(@"Passport number.")]
    PassportNumber = IdentificationCode.PassportNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Social security number.
    /// Encoded/decoded by serializers as &quot;SSYN&quot;.
    /// </summary>
    [EnumMember(Value = "SSYN")]
    [IsoId("_ljy1wad3EeuEcqP2FGAFaA")]
    [Description(@"Social security number.")]
    SocialSecurityNumber = IdentificationCode.SocialSecurityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Alien registration number.
    /// Encoded/decoded by serializers as &quot;ARNB&quot;.
    /// </summary>
    [EnumMember(Value = "ARNB")]
    [IsoId("_ljy1w6d3EeuEcqP2FGAFaA")]
    [Description(@"Alien registration number.")]
    AlienRegistrationNumber = IdentificationCode.AlienRegistrationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other identification provided at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_ljy1xad3EeuEcqP2FGAFaA")]
    [Description(@"Other identification provided at private level.")]
    OtherPrivate = IdentificationCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other identification assigned at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_ljy1x6d3EeuEcqP2FGAFaA")]
    [Description(@"Other identification assigned at national level.")]
    OtherNational = IdentificationCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// E-mail.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_ljy1yad3EeuEcqP2FGAFaA")]
    [Description(@"E-mail.")]
    Email = IdentificationCode.Email, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Phone number.
    /// Encoded/decoded by serializers as &quot;PHNB&quot;.
    /// </summary>
    [EnumMember(Value = "PHNB")]
    [IsoId("_ljy1y6d3EeuEcqP2FGAFaA")]
    [Description(@"Phone number.")]
    PhoneNumber = IdentificationCode.PhoneNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of customer.
    /// Encoded/decoded by serializers as &quot;CUID&quot;.
    /// </summary>
    [EnumMember(Value = "CUID")]
    [IsoId("_wj9Xkad3EeuEcqP2FGAFaA")]
    [Description(@"Identification of customer.")]
    CustomerIdentification = IdentificationCode.CustomerIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax identifier.
    /// Encoded/decoded by serializers as &quot;TXID&quot;.
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("_yiSsgad3EeuEcqP2FGAFaA")]
    [Description(@"Tax identifier.")]
    TaxIdentifier = IdentificationCode.TaxIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proxy
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_0LPnUad3EeuEcqP2FGAFaA")]
    [Description(@"Proxy")]
    Proxy = IdentificationCode.Proxy, // same ordinal as derivation source for type conversions
}
