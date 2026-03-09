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
/// Information related to the result of the certificate management request.
/// </summary>
[IsoId("_mY6FMQ0VEeqUVL7sB4m7NA")]
[DisplayName("Certificate Management Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CertificateManagementResponse2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CertificateManagementResponse2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CertificateManagementResponse2( GenericIdentification176 reqPOIIdentification,CardPaymentServiceType10Code reqCertificateService,ResponseType6 reqResult )
    {
        POIIdentification = reqPOIIdentification;
        CertificateService = reqCertificateService;
        Result = reqResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal or system using the certificate management service.
    /// </summary>
    [IsoId("_mjztoQ0VEeqUVL7sB4m7NA")]
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
    [IsoId("_mjztow0VEeqUVL7sB4m7NA")]
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
    [IsoId("_mjztpQ0VEeqUVL7sB4m7NA")]
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
    /// Outcome of the certificate service processing.
    /// </summary>
    [IsoId("_mjztpw0VEeqUVL7sB4m7NA")]
    [DisplayName("Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rslt")]
    #endif
    [IsoXmlTag("Rslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType6 Result { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType6 Result { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType6 Result { get; init; } 
    #else
    public ResponseType6 Result { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the security profile, for creation, renewal or revocation of certificate.
    /// </summary>
    [IsoId("_mjztqQ0VEeqUVL7sB4m7NA")]
    [DisplayName("Security Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyPrfl")]
    #endif
    [IsoXmlTag("SctyPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecurityProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecurityProfile { get; init; } 
    #else
    public System.String? SecurityProfile { get; set; } 
    #endif
    
    /// <summary>
    /// Created or renewed certificate. The certificate is ASN.1/DER encoded.
    /// </summary>
    [IsoId("_mjztqw0VEeqUVL7sB4m7NA")]
    [DisplayName("Client Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntCert")]
    #endif
    [IsoXmlTag("ClntCert")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3000Binary? ClientCertificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ClientCertificate { get; init; } 
    #else
    public System.Byte[]? ClientCertificate { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate of the client certificate path, from the CA (Certificate Authority) certificate, to the root certificate, for renewal or revocation of certificate.
    /// </summary>
    [IsoId("_mjztrQ0VEeqUVL7sB4m7NA")]
    [DisplayName("Client Certificate Path")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntCertPth")]
    #endif
    [IsoXmlTag("ClntCertPth")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10KBinary? ClientCertificatePath { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ClientCertificatePath { get; init; } 
    #else
    public System.Byte[]? ClientCertificatePath { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate of the server certificate path, from the CA (Certificate Authority) certificate, to the root certificate, for renewal or revocation of certificate.
    /// </summary>
    [IsoId("_mjztrw0VEeqUVL7sB4m7NA")]
    [DisplayName("Server Certificate Path")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvrCertPth")]
    #endif
    [IsoXmlTag("SvrCertPth")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10KBinary? ServerCertificatePath { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ServerCertificatePath { get; init; } 
    #else
    public System.Byte[]? ServerCertificatePath { get; set; } 
    #endif
    
    
    #nullable disable
    
}
