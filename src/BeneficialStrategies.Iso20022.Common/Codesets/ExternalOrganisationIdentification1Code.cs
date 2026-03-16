// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external organisation identification scheme name code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ame0hNp-Ed-ak6NoX_4Aeg_-1667686354")]
[Description(
    @"Specifies the external organisation identification scheme name code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalOrganisationIdentificationCode))]
public enum ExternalOrganisationIdentification1Code
{
    /// <summary>
    /// Unique and unambiguous assignment made by a specific bank or similar financial institution to identify a relationship as defined between the bank and its client.
    /// Encoded/decoded by serializers as &quot;BANK&quot;.
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("_tsHdsvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Unique and unambiguous assignment made by a specific bank or similar financial institution to identify a relationship as defined between the bank and its client. "
    )]
    BankPartyIdentification = ExternalOrganisationIdentificationCode.BankPartyIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A unique identification number assigned by a central bank to identify an organisation.
    /// Encoded/decoded by serializers as &quot;CBID&quot;.
    /// </summary>
    [EnumMember(Value = "CBID")]
    [IsoId("_tsHdtfRYEeuLhpyIdtJzwg")]
    [Description(
        @"A unique identification number assigned by a central bank to identify an organisation."
    )]
    CentralBankIdentificationNumber =
        ExternalOrganisationIdentificationCode.CentralBankIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A unique identification number assigned by a clearing house to identify an organisation
    /// Encoded/decoded by serializers as &quot;CHID&quot;.
    /// </summary>
    [EnumMember(Value = "CHID")]
    [IsoId("_tsHduPRYEeuLhpyIdtJzwg")]
    [Description(
        @"A unique identification number assigned by a clearing house to identify an organisation"
    )]
    ClearingIdentificationNumber =
        ExternalOrganisationIdentificationCode.ClearingIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A unique identification number assigned by a designated authority to a certificate of incorporation and used to identify an organisation.
    /// Encoded/decoded by serializers as &quot;CINC&quot;.
    /// </summary>
    [EnumMember(Value = "CINC")]
    [IsoId("_tsHdu_RYEeuLhpyIdtJzwg")]
    [Description(
        @"A unique identification number assigned by a designated authority to a certificate of incorporation and used to identify an organisation."
    )]
    CertificateOfIncorporationNumber =
        ExternalOrganisationIdentificationCode.CertificateOfIncorporationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Country authority given organisation identification (e.g., corporate registration number)
    /// Encoded/decoded by serializers as &quot;COID&quot;.
    /// </summary>
    [EnumMember(Value = "COID")]
    [IsoId("_tsHdvvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Country authority given organisation identification (e.g., corporate registration number)"
    )]
    CountryIdentificationCode = ExternalOrganisationIdentificationCode.CountryIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by an issuer to identify a customer.|Number assigned by a party to identify a creditor or debtor relationship.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_tsROsvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Number assigned by an issuer to identify a customer.|Number assigned by a party to identify a creditor or debtor relationship."
    )]
    CustomerNumber = ExternalOrganisationIdentificationCode.CustomerNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A unique identification number provided by Dun &amp; Bradstreet to identify an organisation.
    /// Encoded/decoded by serializers as &quot;DUNS&quot;.
    /// </summary>
    [EnumMember(Value = "DUNS")]
    [IsoId("_tsROtfRYEeuLhpyIdtJzwg")]
    [Description(
        @"A unique identification number provided by Dun & Bradstreet to identify an organisation."
    )]
    DataUniversalNumberingSystem =
        ExternalOrganisationIdentificationCode.DataUniversalNumberingSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a registration authority to an employer.
    /// Encoded/decoded by serializers as &quot;EMPL&quot;.
    /// </summary>
    [EnumMember(Value = "EMPL")]
    [IsoId("_tsROuPRYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by a registration authority to an employer.")]
    EmployerIdentificationNumber =
        ExternalOrganisationIdentificationCode.EmployerIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Global Location Number. A non-significant reference number used to identify legal entities, functional entities, or physical entities according to GS1 numbering scheme rules.The number is used to retrieve detailed information that is linked to it.
    /// Encoded/decoded by serializers as &quot;GS1G&quot;.
    /// </summary>
    [EnumMember(Value = "GS1G")]
    [IsoId("_tsROu_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Global Location Number. A non-significant reference number used to identify legal entities, functional entities, or physical entities according to GS1 numbering scheme rules.The number is used to retrieve detailed information that is linked to it."
    )]
    GS1GLNIdentifier = ExternalOrganisationIdentificationCode.GS1GLNIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The SIREN number is a 9 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation in France.
    /// Encoded/decoded by serializers as &quot;SREN&quot;.
    /// </summary>
    [EnumMember(Value = "SREN")]
    [IsoId("_tsROvvRYEeuLhpyIdtJzwg")]
    [Description(
        @"The SIREN number is a 9 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation in France."
    )]
    SIREN = ExternalOrganisationIdentificationCode.SIREN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The SIRET number is a 14 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation unit in France. It consists of the SIREN number, followed by a five digit classification number, to identify the local geographical unit of that entity
    /// Encoded/decoded by serializers as &quot;SRET&quot;.
    /// </summary>
    [EnumMember(Value = "SRET")]
    [IsoId("_tsaYovRYEeuLhpyIdtJzwg")]
    [Description(
        @"The SIRET number is a 14 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation unit in France. It consists of the SIREN number, followed by a five digit classification number, to identify the local geographical unit of that entity"
    )]
    SIRET = ExternalOrganisationIdentificationCode.SIRET, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a tax authority to identify an organisation.
    /// Encoded/decoded by serializers as &quot;TXID&quot;.
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("_tsaYpfRYEeuLhpyIdtJzwg")]
    [Description(@"Number assigned by a tax authority to identify an organisation.")]
    TaxIdentificationNumber = ExternalOrganisationIdentificationCode.TaxIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifier of the business domain in which the organisation is active.
    /// Encoded/decoded by serializers as &quot;BDID&quot;.
    /// </summary>
    [EnumMember(Value = "BDID")]
    [IsoId("_kx6PsVEGEey6cYDbEubNXg")]
    [Description(@"Identifier of the business domain in which the organisation is active.")]
    BusinessDomainIdentifier = ExternalOrganisationIdentificationCode.BusinessDomainIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other identification of the organisation.
    /// Encoded/decoded by serializers as &quot;BOID&quot;.
    /// </summary>
    [EnumMember(Value = "BOID")]
    [IsoId("_k59YcVEGEey6cYDbEubNXg")]
    [Description(@"Other identification of the organisation.")]
    BusinessOtherIdentification =
        ExternalOrganisationIdentificationCode.BusinessOtherIdentification, // same ordinal as derivation source for type conversions
}
