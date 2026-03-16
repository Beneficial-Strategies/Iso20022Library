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
[IsoId("_DSuiIIKZEeeCI5iKR7LsYQ")]
[Description(
    @"Specifies the external person identification scheme name code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalPersonIdentification1Code))]
public enum ExternalPersonIdentificationCode
{
    /// <summary>
    /// Number assigned by a social security agency to identify a non-resident person.
    /// Encoded/decoded by serializers as &quot;ARNU&quot;.
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("_tsaYpvRYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by a social security agency to identify a non-resident person.")]
    AlienRegistrationNumber,

    /// <summary>
    /// Number assigned by an authority to identify the passport number of a person.
    /// Encoded/decoded by serializers as &quot;CCPT&quot;.
    /// </summary>
    [EnumMember(Value = "CCPT")]
    [IsoId("_tsaYqfRYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by an authority to identify the passport number of a person.")]
    PassportNumber,

    /// <summary>
    /// Number assigned by an issuer to identify a customer.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_tsaYrPRYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by an issuer to identify a customer.")]
    CustomerIdentificationNumber,

    /// <summary>
    /// Number assigned by an authority to identify a driver&apos;s license.
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_tskJoPRYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by an authority to identify a driver's license.")]
    DriversLicenseNumber,

    /// <summary>
    /// Number assigned by a registration authority to an employee.
    /// Encoded/decoded by serializers as &quot;EMPL&quot;.
    /// </summary>
    [EnumMember(Value = "EMPL")]
    [IsoId("_tskJo_RYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by a registration authority to an employee.")]
    EmployeeIdentificationNumber,

    /// <summary>
    /// Number assigned by an authority to identify the national identity number of a person.
    /// Encoded/decoded by serializers as &quot;NIDN&quot;.
    /// </summary>
    [EnumMember(Value = "NIDN")]
    [IsoId("_tskJpvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Number assigned by an authority to identify the national identity number of a person."
    )]
    NationalIdentityNumber,

    /// <summary>
    /// Number assigned by an authority to identify the social security number of a person.
    /// Encoded/decoded by serializers as &quot;SOSE&quot;.
    /// </summary>
    [EnumMember(Value = "SOSE")]
    [IsoId("_tskJqfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Number assigned by an authority to identify the social security number of a person."
    )]
    SocialSecurityNumber,

    /// <summary>
    /// Number assigned by a telephone or mobile phone operator to identify a person. A person may have multiple phone numbers.
    /// Encoded/decoded by serializers as &quot;TELE&quot;.
    /// </summary>
    [EnumMember(Value = "TELE")]
    [IsoId("_tskJrPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Number assigned by a telephone or mobile phone operator to identify a person. A person may have multiple phone numbers."
    )]
    TelephoneNumber,

    /// <summary>
    /// Number assigned by a tax authority to identify a person.
    /// Encoded/decoded by serializers as &quot;TXID&quot;.
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("_tst6oPRYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by a tax authority to identify a person.")]
    TaxIdentificationNumber,

    /// <summary>
    /// Commercial identification of the person.
    /// Encoded/decoded by serializers as &quot;POID&quot;.
    /// </summary>
    [EnumMember(Value = "POID")]
    [IsoId("_eXveEFEFEey6cYDbEubNXg")]
    [Description(@"Commercial identification of the person.")]
    PersonCommercialIdentification,
}
