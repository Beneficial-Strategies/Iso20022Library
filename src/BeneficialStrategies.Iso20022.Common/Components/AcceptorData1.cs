// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related the acceptor.
/// </summary>
[IsoId("_NhZjwRT3EfC_aaedwHHlmw")]
[DisplayName("Acceptor Data1")]
public record AcceptorData1
{
    /// <summary>
    /// Identification of the acceptor.
    /// </summary>
    [IsoId("_NotssRT3EfC_aaedwHHlmw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Unique identification to the acceptor assigned by the scheme.
    /// </summary>
    [IsoId("_m4PXwBUZEfC_aaedwHHlmw")]
    [DisplayName("Scheme Assigned Identification")]
    [IsoXmlTag("SchmeAssgndId")]
    public IsoMax15AlphaNumericText? SchemeAssignedIdentification { get; init; }

    /// <summary>
    /// Business name of the acceptor.
    /// </summary>
    [IsoId("_NotsuxT3EfC_aaedwHHlmw")]
    [DisplayName("Business Name")]
    [IsoXmlTag("BizNm")]
    public IsoMax35Text? BusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the party.
    /// </summary>
    [IsoId("_NotsvRT3EfC_aaedwHHlmw")]
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Name and location of acceptor.
    /// </summary>
    [IsoId("_NotswRT3EfC_aaedwHHlmw")]
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    public required IsoMax99Text NameAndLocation { get; init; }

    /// <summary>
    /// Address of the entity.
    /// </summary>
    [IsoId("_Nots1RT3EfC_aaedwHHlmw")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address4? Address { get; init; }

    /// <summary>
    /// Additional information used when card acceptor street address is insufficient.
    /// </summary>
    [IsoId("_Nots4xT3EfC_aaedwHHlmw")]
    [DisplayName("Additional Address")]
    [IsoXmlTag("AddtlAdr")]
    public IsoMax256Text? AdditionalAddress { get; init; }

    /// <summary>
    /// Electronic mail address.
    /// </summary>
    [IsoId("_Nots7RT3EfC_aaedwHHlmw")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    public IsoMax256Text? Email { get; init; }

    /// <summary>
    /// Universal Resource Locator (URL) address.
    /// </summary>
    [IsoId("_Nots9RT3EfC_aaedwHHlmw")]
    [DisplayName("URL")]
    [IsoXmlTag("URL")]
    public IsoMax256Text? URL { get; init; }

    /// <summary>
    /// Collection of information that identifies a phone number as defined by telecom services.
    /// </summary>
    [IsoId("_Nots_RT3EfC_aaedwHHlmw")]
    [DisplayName("Phone")]
    [IsoXmlTag("Phne")]
    public IsoMax35Text? Phone { get; init; }

    /// <summary>
    /// Phone number of the customer service.
    /// </summary>
    [IsoId("_NottBRT3EfC_aaedwHHlmw")]
    [DisplayName("Customer Service")]
    [IsoXmlTag("CstmrSvc")]
    public IsoMax35Text? CustomerService { get; init; }

    /// <summary>
    /// Additional information used to facilitate contact with the card acceptor.
    /// </summary>
    [IsoId("_NottDRT3EfC_aaedwHHlmw")]
    [DisplayName("Additional Contact")]
    [IsoXmlTag("AddtlCtct")]
    public IsoMax256Text? AdditionalContact { get; init; }

    /// <summary>
    /// Contains business registration Identification of the acceptor.
    /// </summary>
    [IsoId("_rHDzQiRcEfCa6bxMAKEOKg")]
    [DisplayName("Business Registration Identification")]
    [IsoXmlTag("BizRegnId")]
    public IsoMax35Text? BusinessRegistrationIdentification { get; init; }

    /// <summary>
    /// Contains the type of acceptor's business registration Identification.
    /// </summary>
    [IsoId("_rHDzQyRcEfCa6bxMAKEOKg")]
    [DisplayName("Business Registration Identification Type")]
    [IsoXmlTag("BizRegnIdTp")]
    public IsoMax35Text? BusinessRegistrationIdentificationType { get; init; }

    /// <summary>
    /// Location where the cardholder receives the service.
    /// </summary>
    [IsoId("_ER3qYBT9EfC_aaedwHHlmw")]
    [DisplayName("Service Location")]
    [IsoXmlTag("SvcLctn")]
    public Address4? ServiceLocation { get; init; }

    /// <summary>
    /// Contains local language equivalent(s) of data in the current component.
    /// </summary>
    [IsoId("_NottFxT3EfC_aaedwHHlmw")]
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData19> LocalData { get; init; } = [];

    /// <summary>
    /// Contains a code that facilitates card acceptor/corporation communication and record keeping.
    /// </summary>
    [IsoId("_NottGxT3EfC_aaedwHHlmw")]
    [DisplayName("Additional Transaction Reference Number")]
    [IsoXmlTag("AddtlTxRefNb")]
    public IsoMax70Text? AdditionalTransactionReferenceNumber { get; init; }

    /// <summary>
    /// Identification of the company recognized by the taxation authority.
    /// </summary>
    [IsoId("_NottHRT3EfC_aaedwHHlmw")]
    [DisplayName("Corporate Tax Identification")]
    [IsoXmlTag("CorpTaxId")]
    public IsoMax35Text? CorporateTaxIdentification { get; init; }

    /// <summary>
    /// Indicates the corporate tax identification type.
    /// </summary>
    [IsoId("_NottHxT3EfC_aaedwHHlmw")]
    [DisplayName("Corporate Tax Identification Type")]
    [IsoXmlTag("CorpTaxIdTp")]
    public CorporateTaxType1Code? CorporateTaxIdentificationType { get; init; }

    /// <summary>
    /// Specific type of business.
    /// </summary>
    [IsoId("_NottIRT3EfC_aaedwHHlmw")]
    [DisplayName("Business Type")]
    [IsoXmlTag("BizTp")]
    public IsoMax35Text? BusinessType { get; init; }

    /// <summary>
    /// Party that provided the business type information.
    /// </summary>
    [IsoId("_NottIxT3EfC_aaedwHHlmw")]
    [DisplayName("Business Type Provided By")]
    [IsoXmlTag("BizTpPrvddBy")]
    public IsoMax35Text? BusinessTypeProvidedBy { get; init; }

    /// <summary>
    /// Specific type of ownership.
    /// </summary>
    [IsoId("_NottJRT3EfC_aaedwHHlmw")]
    [DisplayName("Owner Type")]
    [IsoXmlTag("OwnrTp")]
    public IsoMax35Text? OwnerType { get; init; }

    /// <summary>
    /// Party that provided the owner type information.
    /// </summary>
    [IsoId("_NottJxT3EfC_aaedwHHlmw")]
    [DisplayName("Owner Type Provided By")]
    [IsoXmlTag("OwnrTpPrvddBy")]
    public IsoMax35Text? OwnerTypeProvidedBy { get; init; }

    /// <summary>
    /// Specific type of certification.
    /// </summary>
    [IsoId("_NottKRT3EfC_aaedwHHlmw")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public IsoMax35Text? CertificationType { get; init; }

    /// <summary>
    /// Party that provided the certification type information.
    /// </summary>
    [IsoId("_NottKxT3EfC_aaedwHHlmw")]
    [DisplayName("Certification Type Provided By")]
    [IsoXmlTag("CertfctnTpPrvddBy")]
    public IsoMax35Text? CertificationTypeProvidedBy { get; init; }

    /// <summary>
    /// Specific type of owner ethnicity.
    /// </summary>
    [IsoId("_NottLRT3EfC_aaedwHHlmw")]
    [DisplayName("Owner Ethnicity Type")]
    [IsoXmlTag("OwnrEthnctyTp")]
    public IsoMax35Text? OwnerEthnicityType { get; init; }

    /// <summary>
    /// Party that provided the owner ethnicity type information.
    /// </summary>
    [IsoId("_NottLxT3EfC_aaedwHHlmw")]
    [DisplayName("Owner Ethnicity Type Provided By")]
    [IsoXmlTag("OwnrEthnctyTpPrvddBy")]
    public IsoMax35Text? OwnerEthnicityTypeProvidedBy { get; init; }

    /// <summary>
    /// Identifies a specific partnership agreement, generally between specific acceptors and issuers.
    /// </summary>
    [IsoId("_5Geb0CRZEfCa6bxMAKEOKg")]
    [DisplayName("Partner Identification")]
    [IsoXmlTag("PrtnrId")]
    public IsoMax35Text? PartnerIdentification { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_bmHX8kVYEfCQAqQ9lolFUg")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<LaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_bmHX80VYEfCQAqQ9lolFUg")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<LaxProcessing> NationalData { get; init; } = [];
}
