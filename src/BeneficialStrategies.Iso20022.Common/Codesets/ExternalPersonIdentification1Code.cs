// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external person identification scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ame0hdp-Ed-ak6NoX_4Aeg_-1698163033")]
[Description(@"Specifies the external person identification scheme name code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalPersonIdentificationCode))]
public enum ExternalPersonIdentification1Code
{
    /// <summary>
    /// Number assigned by a social security agency to identify a non-resident person.
    /// Encoded/decoded by serializers as &quot;ARNU&quot;.
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("_tsaYqPRYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by a social security agency to identify a non-resident person.")]
    AlienRegistrationNumber = ExternalPersonIdentificationCode.AlienRegistrationNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by an authority to identify the passport number of a person.
    /// Encoded/decoded by serializers as &quot;CCPT&quot;.
    /// </summary>
    [EnumMember(Value = "CCPT")]
    [IsoId("_tsaYq_RYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by an authority to identify the passport number of a person.")]
    PassportNumber = ExternalPersonIdentificationCode.PassportNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by an issuer to identify a customer.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_tsaYrvRYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by an issuer to identify a customer.")]
    CustomerIdentificationNumber = ExternalPersonIdentificationCode.CustomerIdentificationNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by an authority to identify a driver&apos;s license.
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_tskJovRYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by an authority to identify a driver's license.")]
    DriversLicenseNumber = ExternalPersonIdentificationCode.DriversLicenseNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by a registration authority to an employee.
    /// Encoded/decoded by serializers as &quot;EMPL&quot;.
    /// </summary>
    [EnumMember(Value = "EMPL")]
    [IsoId("_tskJpfRYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by a registration authority to an employee.")]
    EmployeeIdentificationNumber = ExternalPersonIdentificationCode.EmployeeIdentificationNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by an authority to identify the national identity number of a person.
    /// Encoded/decoded by serializers as &quot;NIDN&quot;.
    /// </summary>
    [EnumMember(Value = "NIDN")]
    [IsoId("_tskJqPRYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by an authority to identify the national identity number of a person.")]
    NationalIdentityNumber = ExternalPersonIdentificationCode.NationalIdentityNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by an authority to identify the social security number of a person.
    /// Encoded/decoded by serializers as &quot;SOSE&quot;.
    /// </summary>
    [EnumMember(Value = "SOSE")]
    [IsoId("_tskJq_RYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by an authority to identify the social security number of a person.")]
    SocialSecurityNumber = ExternalPersonIdentificationCode.SocialSecurityNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by a telephone or mobile phone operator to identify a person. A person may have multiple phone numbers.
    /// Encoded/decoded by serializers as &quot;TELE&quot;.
    /// </summary>
    [EnumMember(Value = "TELE")]
    [IsoId("_tskJrvRYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by a telephone or mobile phone operator to identify a person. A person may have multiple phone numbers.")]
    TelephoneNumber = ExternalPersonIdentificationCode.TelephoneNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number assigned by a tax authority to identify a person.
    /// Encoded/decoded by serializers as &quot;TXID&quot;.
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("_tst6ovRYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by a tax authority to identify a person.")]
    TaxIdentificationNumber = ExternalPersonIdentificationCode.TaxIdentificationNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commercial identification of the person.
    /// Encoded/decoded by serializers as &quot;POID&quot;.
    /// </summary>
    [EnumMember(Value = "POID")]
    [IsoId("_vcc8QVEFEey6cYDbEubNXg")]
    [Description(@"Commercial identification of the person.")]
    PersonCommercialIdentification = ExternalPersonIdentificationCode.PersonCommercialIdentification, // same ordinal as derivation source for type conversions
    
}
