// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a payer.
/// </summary>
[IsoId("_kqIgsSzvEfCD0_iZ8tw-zA")]
[DisplayName("Payer Data1")]
public record PayerData1
{
    /// <summary>
    /// Financial institution-related data required by business and/or regulation (for example, money or funds transfer).
    /// </summary>
    [IsoId("_ktRUQSzvEfCD0_iZ8tw-zA")]
    [DisplayName("Financial Institution")]
    [IsoXmlTag("FI")]
    public FinancialInstitution10? FinancialInstitution { get; init; }

    /// <summary>
    /// Identification of the payer.
    /// </summary>
    [IsoId("_ktRUQyzvEfCD0_iZ8tw-zA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Identifies the specific payer when multiple payers are associated with the same account.
    /// </summary>
    [IsoId("_ktRUVyzvEfCD0_iZ8tw-zA")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    public IsoMax2NumericText? Designation { get; init; }

    /// <summary>
    /// Entity type of the payer, such as business, or individul.
    /// </summary>
    [IsoId("_iRbSACzxEfCD0_iZ8tw-zA")]
    [DisplayName("Entity Type")]
    [IsoXmlTag("NttyTp")]
    public IsoMax3Text? EntityType { get; init; }

    /// <summary>
    /// Type of the payer's account identifier.
    /// </summary>
    [IsoId("_HlvdECzyEfCD0_iZ8tw-zA")]
    [DisplayName("Account Identifier Type")]
    [IsoXmlTag("AcctIdrTp")]
    public ISO8583AccountIdentifierTypeCode? AccountIdentifierType { get; init; }

    /// <summary>
    /// Value of the payer's account identifier.
    /// </summary>
    [IsoId("_jBfAgCzyEfCD0_iZ8tw-zA")]
    [DisplayName("Account Identifier")]
    [IsoXmlTag("AcctIdr")]
    public IsoMax70Text? AccountIdentifier { get; init; }

    /// <summary>
    /// Credentials of the payer.
    /// </summary>
    [IsoId("_ktRUayzvEfCD0_iZ8tw-zA")]
    [DisplayName("Credentials")]
    [IsoXmlTag("Crdntls")]
    public ValueList<Credentials3> Credentials { get; init; } = [];

    /// <summary>
    /// Name of the cardholder, which is usually the full name.
    /// </summary>
    [IsoId("_eDkslFN0EfC0lMwgjvMClw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax105Text? Name { get; init; }

    /// <summary>
    /// First name of the cardholder.
    /// </summary>
    [IsoId("_eDkslVN0EfC0lMwgjvMClw")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Middle name or initials present in the name of a person.
    /// </summary>
    [IsoId("_eDksllN0EfC0lMwgjvMClw")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    public IsoMax35Text? MiddleName { get; init; }

    /// <summary>
    /// Family name of the cardholder.
    /// </summary>
    [IsoId("_eDksl1N0EfC0lMwgjvMClw")]
    [DisplayName("Last Name")]
    [IsoXmlTag("LastNm")]
    public IsoMax35Text? LastName { get; init; }

    /// <summary>
    /// Address of the payer.
    /// </summary>
    [IsoId("_ktRUkyzvEfCD0_iZ8tw-zA")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    /// <summary>
    /// Detail contact information of the payer.
    /// </summary>
    [IsoId("_ktRUpyzvEfCD0_iZ8tw-zA")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public ContactPersonal2? Contact { get; init; }

    /// <summary>
    /// Nationality information (ISO 3166-1 alpha-2 or alpha-3) of the payer.
    /// </summary>
    [IsoId("_ktRUqSzvEfCD0_iZ8tw-zA")]
    [DisplayName("Nationality")]
    [IsoXmlTag("Ntlty")]
    public ISOMax3ACountryCode? Nationality { get; init; }

    /// <summary>
    /// Country of Birth information (ISO 3166-1 alpha-2 or alpha-3) of the payer.
    /// </summary>
    [IsoId("_ktRUqyzvEfCD0_iZ8tw-zA")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public ISOMax3ACountryCode? CountryOfBirth { get; init; }

    /// <summary>
    /// Date of birth of the payer.
    /// </summary>
    [IsoId("_ktRUrSzvEfCD0_iZ8tw-zA")]
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    public IsoISODate? DateOfBirth { get; init; }

    /// <summary>
    /// Alias name of the payer.
    /// </summary>
    [IsoId("_6A_pMCzyEfCD0_iZ8tw-zA")]
    [DisplayName("Alias Name")]
    [IsoXmlTag("AliasNm")]
    public IsoMax70Text? AliasName { get; init; }

    /// <summary>
    /// The occupation of the payer.
    /// </summary>
    [IsoId("_rihNcCzyEfCD0_iZ8tw-zA")]
    [DisplayName("Occupation")]
    [IsoXmlTag("Ocptn")]
    public IsoMax35Text? Occupation { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_0dVwMkVYEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_0dVwM0VYEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Contains text fields in the local language.
    /// </summary>
    [IsoId("_ktRUsSzvEfCD0_iZ8tw-zA")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData21? LocalData { get; init; }
}
