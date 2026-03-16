// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of certificate management.
/// </summary>
[IsoId("_9xqf4XIvEe299ZbWCkdR_w")]
[DisplayName("Certificate Management Request")]
public record CertificateManagementRequest3
{
    /// <summary>
    /// Identification of the terminal or system using the certificate management service.
    /// </summary>
    [IsoId("_94jLAXIvEe299ZbWCkdR_w")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification176 POIIdentification { get; init; }

    /// <summary>
    /// Identification of the TM or the MTM providing the Certificate Authority service.
    /// </summary>
    [IsoId("_94jLA3IvEe299ZbWCkdR_w")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public GenericIdentification176? TMIdentification { get; init; }

    /// <summary>
    /// Requested certificate management service.
    /// </summary>
    [IsoId("_94jLBXIvEe299ZbWCkdR_w")]
    [DisplayName("Certificate Service")]
    [IsoXmlTag("CertSvc")]
    public required CardPaymentServiceType10Code CertificateService { get; init; }

    /// <summary>
    /// Identification of the client and server public key infrastructures containing the certificate. In addition, it may identify specific requirements of the customer.
    /// </summary>
    [IsoId("_94jLB3IvEe299ZbWCkdR_w")]
    [DisplayName("Security Domain")]
    [IsoXmlTag("SctyDomn")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SecurityDomain { get; init; }

    /// <summary>
    /// Identifies type of function that could be used with the Key.
    /// </summary>
    [IsoId("_4c7aYHIwEe299ZbWCkdR_w")]
    [DisplayName("Key Function")]
    [IsoXmlTag("KeyFctn")]
    public KeyUsage1Code? KeyFunction { get; init; }

    /// <summary>
    /// Challenge value sends by the POI to be received back in a message response.
    /// </summary>
    [IsoId("_nO-EIHIxEe299ZbWCkdR_w")]
    [DisplayName("POI Challenge Value")]
    [IsoXmlTag("POIChllngVal")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public required IsoMax140Binary POIChallengeValue { get; init; }

    /// <summary>
    /// Date and Time of the POI.
    /// </summary>
    [IsoId("_JNvPsHIyEe299ZbWCkdR_w")]
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime POIDateTime { get; init; }

    /// <summary>
    /// PKCS#10 (Public Key Certificate Standard 10) certification request coded in base64 ASN.1/DER (Abstract Syntax Notation 1, Distinguished Encoding Rules) or PEM (Privacy Enhanced Message) format.
    /// </summary>
    [IsoId("_94jLCXIvEe299ZbWCkdR_w")]
    [DisplayName("Binary Certification Request")]
    [IsoXmlTag("BinryCertfctnReq")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000, MinimumLength = 1)]
    public IsoMax20000Text? BinaryCertificationRequest { get; init; }

    /// <summary>
    /// Certification request PKCS#10 (Public Key Certificate Standard 10) for creation or renewal of an X.509 certificate.
    /// </summary>
    [IsoId("_94jLC3IvEe299ZbWCkdR_w")]
    [DisplayName("Certification Request")]
    [IsoXmlTag("CertfctnReq")]
    public CertificationRequest1? CertificationRequest { get; init; }

    /// <summary>
    /// Created certificate. The certificate is ASN.1/DER encoded, for renewal or revocation of certificate.
    /// </summary>
    [IsoId("_94jLDXIvEe299ZbWCkdR_w")]
    [DisplayName("Client Certificate")]
    [IsoXmlTag("ClntCert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? ClientCertificate { get; init; }

    /// <summary>
    /// Identification of the white list element, for white list addition or removal.
    /// </summary>
    [IsoId("_94jLD3IvEe299ZbWCkdR_w")]
    [DisplayName("White List Identification")]
    [IsoXmlTag("WhtListId")]
    public PointOfInteraction6? WhiteListIdentification { get; init; }
}
