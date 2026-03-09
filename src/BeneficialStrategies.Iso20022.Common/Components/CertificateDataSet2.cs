// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Formal document used to record a fact and used as proof of the fact, in the context of a commercial trade transaction.
/// </summary>
[IsoId("_2LOxkTANEeOKib24wnHaFg")]
[DisplayName("Certificate Data Set")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CertificateDataSet2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CertificateDataSet2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CertificateDataSet2( DocumentIdentification1 reqDataSetIdentification,TradeCertificateType1Code reqCertificateType,CertifiedCharacteristics2Choice_ reqCertifiedCharacteristics,System.DateOnly reqIssueDate,PartyIdentification26 reqIssuer,System.String reqCertificateIdentification )
    {
        DataSetIdentification = reqDataSetIdentification;
        CertificateType = reqCertificateType;
        CertifiedCharacteristics = reqCertifiedCharacteristics;
        IssueDate = reqIssueDate;
        Issuer = reqIssuer;
        CertificateIdentification = reqCertificateIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the certificate data set.
    /// </summary>
    [IsoId("_2nSbcTANEeOKib24wnHaFg")]
    [DisplayName("Data Set Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetId")]
    #endif
    [IsoXmlTag("DataSetId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification1 DataSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification1 DataSetIdentification { get; init; } 
    #else
    public DocumentIdentification1 DataSetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of the certificate.
    /// </summary>
    [IsoId("_2nSbczANEeOKib24wnHaFg")]
    [DisplayName("Certificate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertTp")]
    #endif
    [IsoXmlTag("CertTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeCertificateType1Code CertificateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeCertificateType1Code CertificateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeCertificateType1Code CertificateType { get; init; } 
    #else
    public TradeCertificateType1Code CertificateType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the certificate data set is required in relation to specific line items, and which line items.
    /// </summary>
    [IsoId("_2nSbdTANEeOKib24wnHaFg")]
    [DisplayName("Line Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineItm")]
    #endif
    [IsoXmlTag("LineItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LineItemAndPOIdentification1? LineItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LineItemAndPOIdentification1? LineItem { get; init; } 
    #else
    public LineItemAndPOIdentification1? LineItem { get; set; } 
    #endif
    
    /// <summary>
    /// Characteristics of the goods that are certified, in the context of a commercial trade transaction.
    /// </summary>
    [IsoId("_2nSbdzANEeOKib24wnHaFg")]
    [DisplayName("Certified Characteristics")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfdChrtcs")]
    #endif
    [IsoXmlTag("CertfdChrtcs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CertifiedCharacteristics2Choice_ CertifiedCharacteristics { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CertifiedCharacteristics2Choice_ CertifiedCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CertifiedCharacteristics2Choice_ CertifiedCharacteristics { get; init; } 
    #else
    public CertifiedCharacteristics2Choice_ CertifiedCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_2nSbeTANEeOKib24wnHaFg")]
    [DisplayName("Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDt")]
    #endif
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate IssueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly IssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly IssueDate { get; init; } 
    #else
    public System.DateOnly IssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the certificate was issued.
    /// </summary>
    [IsoId("_2nSbezANEeOKib24wnHaFg")]
    [DisplayName("Place Of Issue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfIsse")]
    #endif
    [IsoXmlTag("PlcOfIsse")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress5? PlaceOfIssue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress5? PlaceOfIssue { get; init; } 
    #else
    public PostalAddress5? PlaceOfIssue { get; set; } 
    #endif
    
    /// <summary>
    /// Issuer of the certificate, typically the inspection company or its agent.
    /// </summary>
    [IsoId("_2nSbfTANEeOKib24wnHaFg")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification26 Issuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification26 Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26 Issuer { get; init; } 
    #else
    public PartyIdentification26 Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Date(s) at which inspection of the goods took place.
    /// </summary>
    [IsoId("_2nSbfzANEeOKib24wnHaFg")]
    [DisplayName("Inspection Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InspctnDt")]
    #endif
    [IsoXmlTag("InspctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriodDetails? InspectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriodDetails? InspectionDate { get; init; } 
    #else
    public DatePeriodDetails? InspectionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the inspection has been performed by an authorised inspector.
    /// </summary>
    [IsoId("_2nSbgTANEeOKib24wnHaFg")]
    [DisplayName("Authorised Inspector Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthrsdInspctrInd")]
    #endif
    [IsoXmlTag("AuthrsdInspctrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AuthorisedInspectorIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthorisedInspectorIndicator { get; init; } 
    #else
    public System.String? AuthorisedInspectorIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier of the document.
    /// </summary>
    [IsoId("_2nSbgzANEeOKib24wnHaFg")]
    [DisplayName("Certificate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertId")]
    #endif
    [IsoXmlTag("CertId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CertificateIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CertificateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CertificateIdentification { get; init; } 
    #else
    public System.String CertificateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Transport information relative to the goods that are covered by the certificate.
    /// </summary>
    [IsoId("_2nSbhTANEeOKib24wnHaFg")]
    [DisplayName("Transport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trnsprt")]
    #endif
    [IsoXmlTag("Trnsprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SingleTransport3? Transport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SingleTransport3? Transport { get; init; } 
    #else
    public SingleTransport3? Transport { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the goods and/or services of a trade transaction.
    /// </summary>
    [IsoId("_2nSbhzANEeOKib24wnHaFg")]
    [DisplayName("Goods Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GoodsDesc")]
    #endif
    [IsoXmlTag("GoodsDesc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? GoodsDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GoodsDescription { get; init; } 
    #else
    public System.String? GoodsDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Party responsible for dispatching the goods.
    /// </summary>
    [IsoId("_2nSbiTANEeOKib24wnHaFg")]
    [DisplayName("Consignor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Consgnr")]
    #endif
    [IsoXmlTag("Consgnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification26? Consignor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26? Consignor { get; init; } 
    #else
    public PartyIdentification26? Consignor { get; set; } 
    #endif
    
    /// <summary>
    /// Party to whom the goods (which are the subject of the certificate) must be delivered.
    /// </summary>
    [IsoId("_2nSbizANEeOKib24wnHaFg")]
    [DisplayName("Consignee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Consgn")]
    #endif
    [IsoXmlTag("Consgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification26? Consignee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26? Consignee { get; init; } 
    #else
    public PartyIdentification26? Consignee { get; set; } 
    #endif
    
    /// <summary>
    /// Manufacturer of the goods which are the subject of the certificate.
    /// </summary>
    [IsoId("_2nSbjTANEeOKib24wnHaFg")]
    [DisplayName("Manufacturer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Manfctr")]
    #endif
    [IsoXmlTag("Manfctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification26? Manufacturer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification26? Manufacturer { get; init; } 
    #else
    public PartyIdentification26? Manufacturer { get; set; } 
    #endif
    
    /// <summary>
    /// Additional and important information that could not be captured by structured fields.
    /// </summary>
    [IsoId("_2nSbjzANEeOKib24wnHaFg")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
