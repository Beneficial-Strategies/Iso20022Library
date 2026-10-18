// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification284.
/// </summary>
[IsoId("_IsQoIZB4Ee6TWIDarRgYow")]
[DisplayName("Party Identification284")]
public record PartyIdentification284
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public Max35Text? Identification { get; init; }

    /// <summary>
    /// Assigner.
    /// </summary>
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public Max35Text? Assigner { get; init; }

    /// <summary>
    /// Country.
    /// </summary>
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; }

    /// <summary>
    /// Short Name.
    /// </summary>
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public Max35Text? ShortName { get; init; }

    /// <summary>
    /// Legal Corporate Name.
    /// </summary>
    [DisplayName("Legal Corporate Name")]
    [IsoXmlTag("LglCorpNm")]
    public Max99Text? LegalCorporateName { get; init; }

    /// <summary>
    /// Additional Identification.
    /// </summary>
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public AdditionalData1? AdditionalIdentification { get; init; }

    /// <summary>
    /// Name And Location.
    /// </summary>
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    public Max99Text? NameAndLocation { get; init; }

    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; }

    /// <summary>
    /// Additional Address.
    /// </summary>
    [DisplayName("Additional Address")]
    [IsoXmlTag("AddtlAdr")]
    public Max256Text? AdditionalAddress { get; init; }

    /// <summary>
    /// Geographic Location.
    /// </summary>
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeogcLctn")]
    public GeographicPointInDecimalDegrees? GeographicLocation { get; init; }

    /// <summary>
    /// Email.
    /// </summary>
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    public Max256Text? Email { get; init; }

    /// <summary>
    /// URL Address.
    /// </summary>
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public Max256Text? URLAddress { get; init; }

    /// <summary>
    /// Phone Number.
    /// </summary>
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    public Max35Text? PhoneNumber { get; init; }

    /// <summary>
    /// Customer Service.
    /// </summary>
    [DisplayName("Customer Service")]
    [IsoXmlTag("CstmrSvc")]
    public Max35Text? CustomerService { get; init; }

    /// <summary>
    /// Additional Contact.
    /// </summary>
    [DisplayName("Additional Contact")]
    [IsoXmlTag("AddtlCtct")]
    public Max256Text? AdditionalContact { get; init; }

    /// <summary>
    /// Tax Registration Identification.
    /// </summary>
    [DisplayName("Tax Registration Identification")]
    [IsoXmlTag("TaxRegnId")]
    public Max35Text? TaxRegistrationIdentification { get; init; }

    /// <summary>
    /// Local Data.
    /// </summary>
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData11? LocalData { get; init; }

    /// <summary>
    /// Corporate Tax Identification.
    /// </summary>
    [DisplayName("Corporate Tax Identification")]
    [IsoXmlTag("CorpTaxId")]
    public Max35Text? CorporateTaxIdentification { get; init; }

    /// <summary>
    /// Corporate Tax Identification Type.
    /// </summary>
    [DisplayName("Corporate Tax Identification Type")]
    [IsoXmlTag("CorpTaxIdTp")]
    public CorporateTaxType1Code? CorporateTaxIdentificationType { get; init; }

    /// <summary>
    /// Business Type.
    /// </summary>
    [DisplayName("Business Type")]
    [IsoXmlTag("BizTp")]
    public Max35Text? BusinessType { get; init; }

    /// <summary>
    /// Business Type Provided By.
    /// </summary>
    [DisplayName("Business Type Provided By")]
    [IsoXmlTag("BizTpPrvddBy")]
    public Max35Text? BusinessTypeProvidedBy { get; init; }

    /// <summary>
    /// Owner Type.
    /// </summary>
    [DisplayName("Owner Type")]
    [IsoXmlTag("OwnrTp")]
    public Max35Text? OwnerType { get; init; }

    /// <summary>
    /// Owner Type Provided By.
    /// </summary>
    [DisplayName("Owner Type Provided By")]
    [IsoXmlTag("OwnrTpPrvddBy")]
    public Max35Text? OwnerTypeProvidedBy { get; init; }

    /// <summary>
    /// Certification Type.
    /// </summary>
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public Max35Text? CertificationType { get; init; }

    /// <summary>
    /// Certification Type Provided By.
    /// </summary>
    [DisplayName("Certification Type Provided By")]
    [IsoXmlTag("CertfctnTpPrvddBy")]
    public Max35Text? CertificationTypeProvidedBy { get; init; }

    /// <summary>
    /// Owner Ethnicity Type.
    /// </summary>
    [DisplayName("Owner Ethnicity Type")]
    [IsoXmlTag("OwnrEthnctyTp")]
    public Max35Text? OwnerEthnicityType { get; init; }

    /// <summary>
    /// Owner Ethnicity Type Provided By.
    /// </summary>
    [DisplayName("Owner Ethnicity Type Provided By")]
    [IsoXmlTag("OwnrEthnctyTpPrvddBy")]
    public Max35Text? OwnerEthnicityTypeProvidedBy { get; init; }

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
