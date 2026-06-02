// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the acceptor.
/// </summary>
[IsoId("_KXEPwXRwEfC68Y4jZPNEug")]
[DisplayName("Acceptor Data3")]
public record AcceptorData3
{
    /// <summary>
    /// Identification of the acceptor.
    /// </summary>
    [IsoId("_KaEgcXRwEfC68Y4jZPNEug")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Unique identification to the acceptor assigned by the scheme.
    /// </summary>
    [IsoId("_aIx1AXRwEfC68Y4jZPNEug")]
    [DisplayName("Scheme Assigned Identification")]
    [IsoXmlTag("SchmeAssgndId")]
    public IsoMax15AlphaNumericText? SchemeAssignedIdentification { get; init; }

    /// <summary>
    /// Business name of the acceptor.
    /// </summary>
    [IsoId("_eGu4UXRwEfC68Y4jZPNEug")]
    [DisplayName("Business Name")]
    [IsoXmlTag("BizNm")]
    public IsoMax35Text? BusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the party.
    /// </summary>
    [IsoId("_KaEgeXRwEfC68Y4jZPNEug")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Name and location of acceptor.
    /// </summary>
    [IsoId("_KaEgfXRwEfC68Y4jZPNEug")]
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    public IsoMax99Text? NameAndLocation { get; init; }

    /// <summary>
    /// Address of the entity.
    /// </summary>
    [IsoId("_KaEgkXRwEfC68Y4jZPNEug")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    /// <summary>
    /// Additional information used when card acceptor street address is insufficient.
    /// </summary>
    [IsoId("_KaEgk3RwEfC68Y4jZPNEug")]
    [DisplayName("Additional Address")]
    [IsoXmlTag("AddtlAdr")]
    public IsoMax256Text? AdditionalAddress { get; init; }

    /// <summary>
    /// Electronic mail address.
    /// </summary>
    [IsoId("_KaEgnXRwEfC68Y4jZPNEug")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    public IsoMax256Text? Email { get; init; }

    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// </summary>
    [IsoId("_KaEgn3RwEfC68Y4jZPNEug")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public IsoMax256Text? URLAddress { get; init; }

    /// <summary>
    /// Collection of information that identifies a phone number as defined by telecom services.
    /// </summary>
    [IsoId("_KaEgoXRwEfC68Y4jZPNEug")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    public IsoMax35Text? PhoneNumber { get; init; }

    /// <summary>
    /// Phone number of the customer service.
    /// </summary>
    [IsoId("_KaEgo3RwEfC68Y4jZPNEug")]
    [DisplayName("Customer Service")]
    [IsoXmlTag("CstmrSvc")]
    public IsoMax35Text? CustomerService { get; init; }

    /// <summary>
    /// Additional information used to facilitate contact with the card acceptor.
    /// </summary>
    [IsoId("_KaEgpXRwEfC68Y4jZPNEug")]
    [DisplayName("Additional Contact")]
    [IsoXmlTag("AddtlCtct")]
    public IsoMax256Text? AdditionalContact { get; init; }

    /// <summary>
    /// Contains business registration Identification of the acceptor.
    /// </summary>
    [IsoId("_wbNVQnRwEfC68Y4jZPNEug")]
    [DisplayName("Business Registration Identification")]
    [IsoXmlTag("BizRegnId")]
    public IsoMax35Text? BusinessRegistrationIdentification { get; init; }

    /// <summary>
    /// Contains the type of acceptor's business registration Identification.
    /// </summary>
    [IsoId("_wbNVQ3RwEfC68Y4jZPNEug")]
    [DisplayName("Business Registration Identification Type")]
    [IsoXmlTag("BizRegnIdTp")]
    public IsoMax35Text? BusinessRegistrationIdentificationType { get; init; }

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_KaEgqXRwEfC68Y4jZPNEug")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData19? LocalData { get; init; }

    /// <summary>
    /// Identification of the company recognized by the taxation authority.
    /// </summary>
    [IsoId("_KaEgq3RwEfC68Y4jZPNEug")]
    [DisplayName("Corporate Tax Identification")]
    [IsoXmlTag("CorpTaxId")]
    public IsoMax35Text? CorporateTaxIdentification { get; init; }

    /// <summary>
    /// Indicates the corporate tax identification type.
    /// </summary>
    [IsoId("_KaEgrXRwEfC68Y4jZPNEug")]
    [DisplayName("Corporate Tax Identification Type")]
    [IsoXmlTag("CorpTaxIdTp")]
    public CorporateTaxType1Code? CorporateTaxIdentificationType { get; init; }

    /// <summary>
    /// Specific type of business.
    /// </summary>
    [IsoId("_KaEgr3RwEfC68Y4jZPNEug")]
    [DisplayName("Business Type")]
    [IsoXmlTag("BizTp")]
    public IsoMax35Text? BusinessType { get; init; }

    /// <summary>
    /// Party that provided the business type information.
    /// </summary>
    [IsoId("_KaEgsXRwEfC68Y4jZPNEug")]
    [DisplayName("Business Type Provided By")]
    [IsoXmlTag("BizTpPrvddBy")]
    public IsoMax35Text? BusinessTypeProvidedBy { get; init; }

    /// <summary>
    /// Specific type of ownership.
    /// </summary>
    [IsoId("_KaEgs3RwEfC68Y4jZPNEug")]
    [DisplayName("Owner Type")]
    [IsoXmlTag("OwnrTp")]
    public IsoMax35Text? OwnerType { get; init; }

    /// <summary>
    /// Party that provided the owner type information.
    /// </summary>
    [IsoId("_KaEgtXRwEfC68Y4jZPNEug")]
    [DisplayName("Owner Type Provided By")]
    [IsoXmlTag("OwnrTpPrvddBy")]
    public IsoMax35Text? OwnerTypeProvidedBy { get; init; }

    /// <summary>
    /// Specific type of certification.
    /// </summary>
    [IsoId("_KaEgt3RwEfC68Y4jZPNEug")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public IsoMax35Text? CertificationType { get; init; }

    /// <summary>
    /// Party that provided the certification type information.
    /// </summary>
    [IsoId("_KaEguXRwEfC68Y4jZPNEug")]
    [DisplayName("Certification Type Provided By")]
    [IsoXmlTag("CertfctnTpPrvddBy")]
    public IsoMax35Text? CertificationTypeProvidedBy { get; init; }

    /// <summary>
    /// Specific type of owner ethnicity.
    /// </summary>
    [IsoId("_KaEgu3RwEfC68Y4jZPNEug")]
    [DisplayName("Owner Ethnicity Type")]
    [IsoXmlTag("OwnrEthnctyTp")]
    public IsoMax35Text? OwnerEthnicityType { get; init; }

    /// <summary>
    /// Party that provided the owner ethnicity type information.
    /// </summary>
    [IsoId("_KaEgvXRwEfC68Y4jZPNEug")]
    [DisplayName("Owner Ethnicity Type Provided By")]
    [IsoXmlTag("OwnrEthnctyTpPrvddBy")]
    public IsoMax35Text? OwnerEthnicityTypeProvidedBy { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_mmPbQnRwEfC68Y4jZPNEug")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<LaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_mmPbQ3RwEfC68Y4jZPNEug")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<LaxProcessing> NationalData { get; init; } = [];
}
