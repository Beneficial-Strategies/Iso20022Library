// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the result of the certificate management request.
/// </summary>
[IsoId("_mY6FMQ0VEeqUVL7sB4m7NA")]
[DisplayName("Certificate Management Response")]
public partial record CertificateManagementResponse2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal or system using the certificate management service.
    /// </summary>
    [IsoId("_mjztoQ0VEeqUVL7sB4m7NA")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification176 POIIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the TM or the MTM providing the Certificate Authority service.
    /// </summary>
    [IsoId("_mjztow0VEeqUVL7sB4m7NA")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public GenericIdentification176? TMIdentification { get; init; } 
    
    /// <summary>
    /// Requested certificate management service.
    /// </summary>
    [IsoId("_mjztpQ0VEeqUVL7sB4m7NA")]
    [DisplayName("Certificate Service")]
    [IsoXmlTag("CertSvc")]
    public required CardPaymentServiceType10Code CertificateService { get; init; } 
    
    /// <summary>
    /// Outcome of the certificate service processing.
    /// </summary>
    [IsoId("_mjztpw0VEeqUVL7sB4m7NA")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required ResponseType6 Result { get; init; } 
    
    /// <summary>
    /// Identification of the security profile, for creation, renewal or revocation of certificate.
    /// </summary>
    [IsoId("_mjztqQ0VEeqUVL7sB4m7NA")]
    [DisplayName("Security Profile")]
    [IsoXmlTag("SctyPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecurityProfile { get; init; } 
    
    /// <summary>
    /// Created or renewed certificate. The certificate is ASN.1/DER encoded.
    /// </summary>
    [IsoId("_mjztqw0VEeqUVL7sB4m7NA")]
    [DisplayName("Client Certificate")]
    [IsoXmlTag("ClntCert")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? ClientCertificate { get; init; } 
    
    /// <summary>
    /// Certificate of the client certificate path, from the CA (Certificate Authority) certificate, to the root certificate, for renewal or revocation of certificate.
    /// </summary>
    [IsoId("_mjztrQ0VEeqUVL7sB4m7NA")]
    [DisplayName("Client Certificate Path")]
    [IsoXmlTag("ClntCertPth")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? ClientCertificatePath { get; init; } 
    
    /// <summary>
    /// Certificate of the server certificate path, from the CA (Certificate Authority) certificate, to the root certificate, for renewal or revocation of certificate.
    /// </summary>
    [IsoId("_mjztrw0VEeqUVL7sB4m7NA")]
    [DisplayName("Server Certificate Path")]
    [IsoXmlTag("SvrCertPth")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? ServerCertificatePath { get; init; } 
    
    
    #nullable disable
    
}
