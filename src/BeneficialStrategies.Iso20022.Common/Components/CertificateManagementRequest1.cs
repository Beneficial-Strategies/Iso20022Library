// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of certificate management.
/// </summary>
[IsoId("_199JII4KEeW6h7rGyYlyTg")]
[DisplayName("Certificate Management Request")]
public partial record CertificateManagementRequest1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the terminal or system using the certificate management service.
    /// </summary>
    [IsoId("_-IwAUI4KEeW6h7rGyYlyTg")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification72 POIIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the TM or the MTM providing the Certificate Authority service.
    /// </summary>
    [IsoId("_1pe4gI4LEeW6h7rGyYlyTg")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public GenericIdentification72? TMIdentification { get; init; } 
    
    /// <summary>
    /// Requested certificate management service.
    /// </summary>
    [IsoId("__NSUkI4MEeW6h7rGyYlyTg")]
    [DisplayName("Certificate Service")]
    [IsoXmlTag("CertSvc")]
    public required CardPaymentServiceType10Code CertificateService { get; init; } 
    
    /// <summary>
    /// Identification of the client and server public key infrastructures containing the certificate. In addition, it may identify specific requirements of the customer.
    /// </summary>
    [IsoId("_L1GJoI4NEeW6h7rGyYlyTg")]
    [DisplayName("Security Domain")]
    [IsoXmlTag("SctyDomn")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? SecurityDomain { get; init; } 
    
    /// <summary>
    /// PKCS#10 (Public Key Certificate Standard 10) certification request coded in base64 ASN.1/DER (Abstract Syntax Notation 1, Distinguished Encoding Rules) or PEM (Privacy Enhanced Message) format.
    /// </summary>
    [IsoId("_T2WqUI4NEeW6h7rGyYlyTg")]
    [DisplayName("Binary Certification Request")]
    [IsoXmlTag("BinryCertfctnReq")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    public IsoMax20000Text? BinaryCertificationRequest { get; init; } 
    
    /// <summary>
    /// Certification request PKCS#10 (Public Key Certificate Standard 10) for creation or renewal of an X.509 certificate.
    /// </summary>
    [IsoId("_O_f20I4SEeW6h7rGyYlyTg")]
    [DisplayName("Certification Request")]
    [IsoXmlTag("CertfctnReq")]
    public CertificationRequest1? CertificationRequest { get; init; } 
    
    /// <summary>
    /// Created certificate. The certificate is ASN.1/DER encoded, for renewal or revocation of certificate.
    /// </summary>
    [IsoId("_vjgCoI4UEeW6h7rGyYlyTg")]
    [DisplayName("Client Certificate")]
    [IsoXmlTag("ClntCert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? ClientCertificate { get; init; } 
    
    /// <summary>
    /// Identification of the white list element, for white list addition or removal.
    /// </summary>
    [IsoId("_bk04QI4VEeW6h7rGyYlyTg")]
    [DisplayName("White List Identification")]
    [IsoXmlTag("WhtListId")]
    public PointOfInteraction6? WhiteListIdentification { get; init; } 
    
    
    #nullable disable
    
}
