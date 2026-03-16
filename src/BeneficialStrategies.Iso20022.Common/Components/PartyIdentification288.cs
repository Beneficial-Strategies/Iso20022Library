// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification288.
/// </summary>
[IsoId("_VFIs4W6YEe6DxcrvCrq6hQ")]
[DisplayName("Party Identification288")]
public record PartyIdentification288
{
    /// <summary>
    /// Additional Address.
    /// </summary>
    [DisplayName("Additional Address")]
    [IsoXmlTag("AddtlAdr")]
    public IsoMax256Text? AdditionalAddress { get; init; }

    /// <summary>
    /// Additional Contact.
    /// </summary>
    [DisplayName("Additional Contact")]
    [IsoXmlTag("AddtlCtct")]
    public IsoMax256Text? AdditionalContact { get; init; }

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Additional Identification.
    /// </summary>
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public ValueList<AdditionalData1> AdditionalIdentification { get; init; } = [];

    /// <summary>
    /// Additional Transaction Reference Number.
    /// </summary>
    [DisplayName("Additional Transaction Reference Number")]
    [IsoXmlTag("AddtlTxRefNb")]
    public IsoMax70Text? AdditionalTransactionReferenceNumber { get; init; }

    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Assigner.
    /// </summary>
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public IsoMax35Text? Assigner { get; init; }

    /// <summary>
    /// Business Type.
    /// </summary>
    [DisplayName("Business Type")]
    [IsoXmlTag("BizTp")]
    public IsoMax35Text? BusinessType { get; init; }

    /// <summary>
    /// Business Type Provided By.
    /// </summary>
    [DisplayName("Business Type Provided By")]
    [IsoXmlTag("BizTpPrvddBy")]
    public IsoMax35Text? BusinessTypeProvidedBy { get; init; }

    /// <summary>
    /// Certification Type.
    /// </summary>
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public IsoMax35Text? CertificationType { get; init; }

    /// <summary>
    /// Certification Type Provided By.
    /// </summary>
    [DisplayName("Certification Type Provided By")]
    [IsoXmlTag("CertfctnTpPrvddBy")]
    public IsoMax35Text? CertificationTypeProvidedBy { get; init; }

    /// <summary>
    /// Corporate Tax Identification.
    /// </summary>
    [DisplayName("Corporate Tax Identification")]
    [IsoXmlTag("CorpTaxId")]
    public IsoMax35Text? CorporateTaxIdentification { get; init; }

    /// <summary>
    /// Corporate Tax Identification Type.
    /// </summary>
    [DisplayName("Corporate Tax Identification Type")]
    [IsoXmlTag("CorpTaxIdTp")]
    public CorporateTaxType1Code? CorporateTaxIdentificationType { get; init; }

    /// <summary>
    /// Customer Service.
    /// </summary>
    [DisplayName("Customer Service")]
    [IsoXmlTag("CstmrSvc")]
    public IsoMax35Text? CustomerService { get; init; }

    /// <summary>
    /// Email.
    /// </summary>
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    public IsoMax256Text? Email { get; init; }

    /// <summary>
    /// Geographic Location.
    /// </summary>
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeogcLctn")]
    public IsoGeographicPointInDecimalDegrees? GeographicLocation { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Legal Corporate Name.
    /// </summary>
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public IsoMax99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Local Data.
    /// </summary>
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public ValueList<LocalData11> LocalData { get; init; } = [];

    /// <summary>
    /// Name And Location.
    /// </summary>
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    public required IsoMax99Text NameAndLocation { get; init; }

    /// <summary>
    /// Owner Ethnicity Type.
    /// </summary>
    [DisplayName("Owner Ethnicity Type")]
    [IsoXmlTag("OwnrEthnctyTp")]
    public IsoMax35Text? OwnerEthnicityType { get; init; }

    /// <summary>
    /// Owner Ethnicity Type Provided By.
    /// </summary>
    [DisplayName("Owner Ethnicity Type Provided By")]
    [IsoXmlTag("OwnrEthnctyTpPrvddBy")]
    public IsoMax35Text? OwnerEthnicityTypeProvidedBy { get; init; }

    /// <summary>
    /// Owner Type.
    /// </summary>
    [DisplayName("Owner Type")]
    [IsoXmlTag("OwnrTp")]
    public IsoMax35Text? OwnerType { get; init; }

    /// <summary>
    /// Owner Type Provided By.
    /// </summary>
    [DisplayName("Owner Type Provided By")]
    [IsoXmlTag("OwnrTpPrvddBy")]
    public IsoMax35Text? OwnerTypeProvidedBy { get; init; }

    /// <summary>
    /// Phone.
    /// </summary>
    [DisplayName("Phone")]
    [IsoXmlTag("Phne")]
    public IsoMax35Text? Phone { get; init; }

    /// <summary>
    /// Short Name.
    /// </summary>
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Sponsored Merchant.
    /// </summary>
    [DisplayName("Sponsored Merchant")]
    [IsoXmlTag("SpnsrdMrchnt")]
    public ValueList<SponsoredMerchant3> SponsoredMerchant { get; init; } = [];

    /// <summary>
    /// Tax Registration Identification.
    /// </summary>
    [DisplayName("Tax Registration Identification")]
    [IsoXmlTag("TaxRegnId")]
    public IsoMax35Text? TaxRegistrationIdentification { get; init; }

    /// <summary>
    /// URL.
    /// </summary>
    [DisplayName("URL")]
    [IsoXmlTag("URL")]
    public IsoMax256Text? URL { get; init; }
}
