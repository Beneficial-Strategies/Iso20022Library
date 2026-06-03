// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a payee.
/// </summary>
[IsoId("_Xt_dkSzzEfCD0_iZ8tw-zA")]
[DisplayName("Payee Data1")]
public record PayeeData1
{
    /// <summary>
    /// Financial institution-related data required by business and/or regulation (for example, money or funds transfer).
    /// </summary>
    [IsoId("_XwZRUSzzEfCD0_iZ8tw-zA")]
    [DisplayName("Financial Institution")]
    [IsoXmlTag("FI")]
    public FinancialInstitution10? FinancialInstitution { get; init; }

    /// <summary>
    /// Identification of the payee.
    /// </summary>
    [IsoId("_XwZRUyzzEfCD0_iZ8tw-zA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Identifies the specific payee when multiple payees are associated with the same account.
    /// </summary>
    [IsoId("_XwZRZyzzEfCD0_iZ8tw-zA")]
    [DisplayName("Designation")]
    [IsoXmlTag("Dsgnt")]
    public IsoMax2NumericText? Designation { get; init; }

    /// <summary>
    /// Entity type of the payee, such as business, or individul.
    /// </summary>
    [IsoId("_XwZReyzzEfCD0_iZ8tw-zA")]
    [DisplayName("Entity Type")]
    [IsoXmlTag("NttyTp")]
    public IsoMax3Text? EntityType { get; init; }

    /// <summary>
    /// Type of the payee's account identifier.
    /// </summary>
    [IsoId("_XwZRfSzzEfCD0_iZ8tw-zA")]
    [DisplayName("Account Identifier Type")]
    [IsoXmlTag("AcctIdrTp")]
    public ISO8583AccountIdentifierTypeCode? AccountIdentifierType { get; init; }

    /// <summary>
    /// Value of the payee's account identifier.
    /// </summary>
    [IsoId("_XwZRfyzzEfCD0_iZ8tw-zA")]
    [DisplayName("Account Identifier")]
    [IsoXmlTag("AcctIdr")]
    public IsoMax70Text? AccountIdentifier { get; init; }

    /// <summary>
    /// Credentials of the payee.
    /// </summary>
    [IsoId("_XwZRgSzzEfCD0_iZ8tw-zA")]
    [DisplayName("Credentials")]
    [IsoXmlTag("Crdntls")]
    public ValueList<Credentials3> Credentials { get; init; } = [];

    /// <summary>
    /// Name of the cardholder, which is usually the full name.
    /// </summary>
    [IsoId("_elqF9FN0EfC0lMwgjvMClw")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax105Text? Name { get; init; }

    /// <summary>
    /// First name of the cardholder.
    /// </summary>
    [IsoId("_elqF9VN0EfC0lMwgjvMClw")]
    [DisplayName("Given Name")]
    [IsoXmlTag("GvnNm")]
    public IsoMax35Text? GivenName { get; init; }

    /// <summary>
    /// Middle name or initials present in the name of a person.
    /// </summary>
    [IsoId("_elqF9lN0EfC0lMwgjvMClw")]
    [DisplayName("Middle Name")]
    [IsoXmlTag("MddlNm")]
    public IsoMax35Text? MiddleName { get; init; }

    /// <summary>
    /// Family name of the cardholder.
    /// </summary>
    [IsoId("_elqF91N0EfC0lMwgjvMClw")]
    [DisplayName("Last Name")]
    [IsoXmlTag("LastNm")]
    public IsoMax35Text? LastName { get; init; }

    /// <summary>
    /// Address of the payee.
    /// </summary>
    [IsoId("_XwZRqSzzEfCD0_iZ8tw-zA")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    /// <summary>
    /// Detail contact information of the payee.
    /// </summary>
    [IsoId("_XwZRvSzzEfCD0_iZ8tw-zA")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public ContactPersonal2? Contact { get; init; }

    /// <summary>
    /// Nationality information (ISO 3166-1 alpha-2 or alpha-3) of the payee.
    /// </summary>
    [IsoId("_XwZRvyzzEfCD0_iZ8tw-zA")]
    [DisplayName("Nationality")]
    [IsoXmlTag("Ntlty")]
    public ISOMax3ACountryCode? Nationality { get; init; }

    /// <summary>
    /// Country of Birth information (ISO 3166-1 alpha-2 or alpha-3) of the payee.
    /// </summary>
    [IsoId("_XwZRwSzzEfCD0_iZ8tw-zA")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public ISOMax3ACountryCode? CountryOfBirth { get; init; }

    /// <summary>
    /// Date of birth of the payee.
    /// </summary>
    [IsoId("_XwZRwyzzEfCD0_iZ8tw-zA")]
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    public IsoISODate? DateOfBirth { get; init; }

    /// <summary>
    /// Alias name of the payee.
    /// </summary>
    [IsoId("_XwZRxSzzEfCD0_iZ8tw-zA")]
    [DisplayName("Alias Name")]
    [IsoXmlTag("AliasNm")]
    public IsoMax70Text? AliasName { get; init; }

    /// <summary>
    /// The occupation of the payee.
    /// </summary>
    [IsoId("_XwZRyyzzEfCD0_iZ8tw-zA")]
    [DisplayName("Occupation")]
    [IsoXmlTag("Ocptn")]
    public IsoMax35Text? Occupation { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_7cwZYkVYEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_7cwZY0VYEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Contains text fields in the local language.
    /// </summary>
    [IsoId("_XwZRySzzEfCD0_iZ8tw-zA")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData21? LocalData { get; init; }
}
