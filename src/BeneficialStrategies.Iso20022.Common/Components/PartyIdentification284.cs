// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification284.
/// </summary>
[IsoId("_IsQoIZB4Ee6TWIDarRgYow")]
[DisplayName("Party Identification284")]
public partial record PartyIdentification284
{
    #nullable enable

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
    public AdditionalData1? AdditionalIdentification { get; init; } 

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
    /// Country.
    /// </summary>
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISO3NumericCountryCode? Country { get; init; } 

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
    public IsoMax35Text? Identification { get; init; } 

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
    public LocalData11? LocalData { get; init; } 

    /// <summary>
    /// Name And Location.
    /// </summary>
    [DisplayName("Name And Location")]
    [IsoXmlTag("NmAndLctn")]
    public IsoMax99Text? NameAndLocation { get; init; } 

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
    /// Phone Number.
    /// </summary>
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    public IsoMax35Text? PhoneNumber { get; init; } 

    /// <summary>
    /// Short Name.
    /// </summary>
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax35Text? ShortName { get; init; } 

    /// <summary>
    /// Tax Registration Identification.
    /// </summary>
    [DisplayName("Tax Registration Identification")]
    [IsoXmlTag("TaxRegnId")]
    public IsoMax35Text? TaxRegistrationIdentification { get; init; } 

    /// <summary>
    /// URL Address.
    /// </summary>
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public IsoMax256Text? URLAddress { get; init; } 

    
    #nullable disable
    
}
