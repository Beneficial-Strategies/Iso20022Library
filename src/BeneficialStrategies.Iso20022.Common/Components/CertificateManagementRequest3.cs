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
/// Information related to the request of certificate management.
/// </summary>
[IsoId("_9xqf4XIvEe299ZbWCkdR_w")]
[DisplayName("Certificate Management Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CertificateManagementRequest3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CertificateManagementRequest3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CertificateManagementRequest3( GenericIdentification176 reqPOIIdentification,CardPaymentServiceType10Code reqCertificateService,System.Byte[] reqPOIChallengeValue,System.DateTime reqPOIDateTime )
    {
        POIIdentification = reqPOIIdentification;
        CertificateService = reqCertificateService;
        POIChallengeValue = reqPOIChallengeValue;
        POIDateTime = reqPOIDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal or system using the certificate management service.
    /// </summary>
    [IsoId("_94jLAXIvEe299ZbWCkdR_w")]
    [DisplayName("POI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIId")]
    #endif
    [IsoXmlTag("POIId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification176 POIIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification176 POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification176 POIIdentification { get; init; } 
    #else
    public GenericIdentification176 POIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the TM or the MTM providing the Certificate Authority service.
    /// </summary>
    [IsoId("_94jLA3IvEe299ZbWCkdR_w")]
    [DisplayName("TM Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMId")]
    #endif
    [IsoXmlTag("TMId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification176? TMIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification176? TMIdentification { get; init; } 
    #else
    public GenericIdentification176? TMIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Requested certificate management service.
    /// </summary>
    [IsoId("_94jLBXIvEe299ZbWCkdR_w")]
    [DisplayName("Certificate Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertSvc")]
    #endif
    [IsoXmlTag("CertSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentServiceType10Code CertificateService { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentServiceType10Code CertificateService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType10Code CertificateService { get; init; } 
    #else
    public CardPaymentServiceType10Code CertificateService { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the client and server public key infrastructures containing the certificate. In addition, it may identify specific requirements of the customer.
    /// </summary>
    [IsoId("_94jLB3IvEe299ZbWCkdR_w")]
    [DisplayName("Security Domain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyDomn")]
    #endif
    [IsoXmlTag("SctyDomn")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? SecurityDomain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecurityDomain { get; init; } 
    #else
    public System.String? SecurityDomain { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies type of function that could be used with the Key.
    /// </summary>
    [IsoId("_4c7aYHIwEe299ZbWCkdR_w")]
    [DisplayName("Key Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyFctn")]
    #endif
    [IsoXmlTag("KeyFctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public KeyUsage1Code? KeyFunction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public KeyUsage1Code? KeyFunction { get; init; } 
    #else
    public KeyUsage1Code? KeyFunction { get; set; } 
    #endif
    
    /// <summary>
    /// Challenge value sends by the POI to be received back in a message response.
    /// </summary>
    [IsoId("_nO-EIHIxEe299ZbWCkdR_w")]
    [DisplayName("POI Challenge Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIChllngVal")]
    #endif
    [IsoXmlTag("POIChllngVal")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Binary POIChallengeValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] POIChallengeValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] POIChallengeValue { get; init; } 
    #else
    public System.Byte[] POIChallengeValue { get; set; } 
    #endif
    
    /// <summary>
    /// Date and Time of the POI.
    /// </summary>
    [IsoId("_JNvPsHIyEe299ZbWCkdR_w")]
    [DisplayName("POI Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIDtTm")]
    #endif
    [IsoXmlTag("POIDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime POIDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime POIDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime POIDateTime { get; init; } 
    #else
    public System.DateTime POIDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// PKCS#10 (Public Key Certificate Standard 10) certification request coded in base64 ASN.1/DER (Abstract Syntax Notation 1, Distinguished Encoding Rules) or PEM (Privacy Enhanced Message) format.
    /// </summary>
    [IsoId("_94jLCXIvEe299ZbWCkdR_w")]
    [DisplayName("Binary Certification Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BinryCertfctnReq")]
    #endif
    [IsoXmlTag("BinryCertfctnReq")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax20000Text? BinaryCertificationRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BinaryCertificationRequest { get; init; } 
    #else
    public System.String? BinaryCertificationRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Certification request PKCS#10 (Public Key Certificate Standard 10) for creation or renewal of an X.509 certificate.
    /// </summary>
    [IsoId("_94jLC3IvEe299ZbWCkdR_w")]
    [DisplayName("Certification Request")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnReq")]
    #endif
    [IsoXmlTag("CertfctnReq")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CertificationRequest1? CertificationRequest { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CertificationRequest1? CertificationRequest { get; init; } 
    #else
    public CertificationRequest1? CertificationRequest { get; set; } 
    #endif
    
    /// <summary>
    /// Created certificate. The certificate is ASN.1/DER encoded, for renewal or revocation of certificate.
    /// </summary>
    [IsoId("_94jLDXIvEe299ZbWCkdR_w")]
    [DisplayName("Client Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntCert")]
    #endif
    [IsoXmlTag("ClntCert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10KBinary? ClientCertificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ClientCertificate { get; init; } 
    #else
    public System.Byte[]? ClientCertificate { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the white list element, for white list addition or removal.
    /// </summary>
    [IsoId("_94jLD3IvEe299ZbWCkdR_w")]
    [DisplayName("White List Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhtListId")]
    #endif
    [IsoXmlTag("WhtListId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteraction6? WhiteListIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteraction6? WhiteListIdentification { get; init; } 
    #else
    public PointOfInteraction6? WhiteListIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
