// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Formal document used to record a fact and used as proof of the fact, in the context of a commercial trade transaction.
/// </summary>
[IsoId("_2LOxkTANEeOKib24wnHaFg")]
[DisplayName("Certificate Data Set")]
public partial record CertificateDataSet2
{
    #nullable enable
    
    /// <summary>
    /// Identifies the certificate data set.
    /// </summary>
    [IsoId("_2nSbcTANEeOKib24wnHaFg")]
    [DisplayName("Data Set Identification")]
    [IsoXmlTag("DataSetId")]
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the type of the certificate.
    /// </summary>
    [IsoId("_2nSbczANEeOKib24wnHaFg")]
    [DisplayName("Certificate Type")]
    [IsoXmlTag("CertTp")]
    public required TradeCertificateType1Code CertificateType { get; init; } 
    
    /// <summary>
    /// Specifies if the certificate data set is required in relation to specific line items, and which line items.
    /// </summary>
    [IsoId("_2nSbdTANEeOKib24wnHaFg")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public LineItemAndPOIdentification1? LineItem { get; init; } 
    
    /// <summary>
    /// Characteristics of the goods that are certified, in the context of a commercial trade transaction.
    /// </summary>
    [IsoId("_2nSbdzANEeOKib24wnHaFg")]
    [DisplayName("Certified Characteristics")]
    [IsoXmlTag("CertfdChrtcs")]
    public required CertifiedCharacteristics2Choice_ CertifiedCharacteristics { get; init; } 
    
    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_2nSbeTANEeOKib24wnHaFg")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate IssueDate { get; init; } 
    
    /// <summary>
    /// Place where the certificate was issued.
    /// </summary>
    [IsoId("_2nSbezANEeOKib24wnHaFg")]
    [DisplayName("Place Of Issue")]
    [IsoXmlTag("PlcOfIsse")]
    public PostalAddress5? PlaceOfIssue { get; init; } 
    
    /// <summary>
    /// Issuer of the certificate, typically the inspection company or its agent.
    /// </summary>
    [IsoId("_2nSbfTANEeOKib24wnHaFg")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required PartyIdentification26 Issuer { get; init; } 
    
    /// <summary>
    /// Date(s) at which inspection of the goods took place.
    /// </summary>
    [IsoId("_2nSbfzANEeOKib24wnHaFg")]
    [DisplayName("Inspection Date")]
    [IsoXmlTag("InspctnDt")]
    public DatePeriodDetails? InspectionDate { get; init; } 
    
    /// <summary>
    /// Indicates that the inspection has been performed by an authorised inspector.
    /// </summary>
    [IsoId("_2nSbgTANEeOKib24wnHaFg")]
    [DisplayName("Authorised Inspector Indicator")]
    [IsoXmlTag("AuthrsdInspctrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AuthorisedInspectorIndicator { get; init; } 
    
    /// <summary>
    /// Unique identifier of the document.
    /// </summary>
    [IsoId("_2nSbgzANEeOKib24wnHaFg")]
    [DisplayName("Certificate Identification")]
    [IsoXmlTag("CertId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text CertificateIdentification { get; init; } 
    
    /// <summary>
    /// Transport information relative to the goods that are covered by the certificate.
    /// </summary>
    [IsoId("_2nSbhTANEeOKib24wnHaFg")]
    [DisplayName("Transport")]
    [IsoXmlTag("Trnsprt")]
    public SingleTransport3? Transport { get; init; } 
    
    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    [IsoId("_2nSbhzANEeOKib24wnHaFg")]
    [DisplayName("Goods Description")]
    [IsoXmlTag("GoodsDesc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? GoodsDescription { get; init; } 
    
    /// <summary>
    /// Party responsible for dispatching the goods.
    /// </summary>
    [IsoId("_2nSbiTANEeOKib24wnHaFg")]
    [DisplayName("Consignor")]
    [IsoXmlTag("Consgnr")]
    public PartyIdentification26? Consignor { get; init; } 
    
    /// <summary>
    /// Party to whom the goods (which are the subject of the certificate) must be delivered.
    /// </summary>
    [IsoId("_2nSbizANEeOKib24wnHaFg")]
    [DisplayName("Consignee")]
    [IsoXmlTag("Consgn")]
    public PartyIdentification26? Consignee { get; init; } 
    
    /// <summary>
    /// Manufacturer of the goods which are the subject of the certificate.
    /// </summary>
    [IsoId("_2nSbjTANEeOKib24wnHaFg")]
    [DisplayName("Manufacturer")]
    [IsoXmlTag("Manfctr")]
    public PartyIdentification26? Manufacturer { get; init; } 
    
    /// <summary>
    /// Additional and important information that could not be captured by structured fields.
    /// </summary>
    [IsoId("_2nSbjzANEeOKib24wnHaFg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
