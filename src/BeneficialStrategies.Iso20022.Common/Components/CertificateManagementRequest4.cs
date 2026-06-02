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
[IsoId("_HLB6kZ__EfC4Q_xhaK1hdQ")]
[DisplayName("Certificate Management Request4")]
public record CertificateManagementRequest4
{
    /// <summary>
    /// Identification of the terminal or system using the certificate management service.
    /// </summary>
    [IsoId("_HMZMhZ__EfC4Q_xhaK1hdQ")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification176 POIIdentification { get; init; }

    /// <summary>
    /// Identification of the TM or the MTM providing the Certificate Authority service.
    /// </summary>
    [IsoId("_HMZMi5__EfC4Q_xhaK1hdQ")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public GenericIdentification176? TMIdentification { get; init; }

    /// <summary>
    /// Requested certificate management service.
    /// </summary>
    [IsoId("_HMZMkZ__EfC4Q_xhaK1hdQ")]
    [DisplayName("Certificate Service")]
    [IsoXmlTag("CertSvc")]
    public required CardPaymentServiceType10Code CertificateService { get; init; }

    /// <summary>
    /// Identification of the client and server public key infrastructures containing the certificate.
    /// </summary>
    [IsoId("_HMZMl5__EfC4Q_xhaK1hdQ")]
    [DisplayName("Security Domain")]
    [IsoXmlTag("SctyDomn")]
    public IsoMax70Text? SecurityDomain { get; init; }

    /// <summary>
    /// Identifies type of function that could be used with the Key.
    /// </summary>
    [IsoId("_HMZMnZ__EfC4Q_xhaK1hdQ")]
    [DisplayName("Key Function")]
    [IsoXmlTag("KeyFctn")]
    public SimpleValueList<KeyUsage1Code> KeyFunction { get; init; } = [];

    /// <summary>
    /// Challenge value sends by the POI to be received back in a message response.
    /// </summary>
    [IsoId("_HMZMn5__EfC4Q_xhaK1hdQ")]
    [DisplayName("POI Challenge Value")]
    [IsoXmlTag("POIChllngVal")]
    public required IsoMax140Binary POIChallengeValue { get; init; }

    /// <summary>
    /// Date and Time of the POI.
    /// </summary>
    [IsoId("_HMZMoZ__EfC4Q_xhaK1hdQ")]
    [DisplayName("POI Date Time")]
    [IsoXmlTag("POIDtTm")]
    public required IsoISODateTime POIDateTime { get; init; }

    /// <summary>
    /// PKCS#10 certification request coded in base64 ASN.1/DER or PEM format.
    /// </summary>
    [IsoId("_HMZMo5__EfC4Q_xhaK1hdQ")]
    [DisplayName("Binary Certification Request")]
    [IsoXmlTag("BinryCertfctnReq")]
    public IsoMax20000Text? BinaryCertificationRequest { get; init; }

    /// <summary>
    /// Certification request PKCS#10 for creation or renewal of an X.509 certificate.
    /// </summary>
    [IsoId("_HMZMqZ__EfC4Q_xhaK1hdQ")]
    [DisplayName("Certification Request")]
    [IsoXmlTag("CertfctnReq")]
    public SignedData9? CertificationRequest { get; init; }

    /// <summary>
    /// Created certificate. The certificate is ASN.1/DER encoded, for renewal or revocation of certificate.
    /// </summary>
    [IsoId("_HMZMr5__EfC4Q_xhaK1hdQ")]
    [DisplayName("Client Certificate")]
    [IsoXmlTag("ClntCert")]
    public IsoMax10KBinary? ClientCertificate { get; init; }

    /// <summary>
    /// Identification of the white list element, for white list addition or removal.
    /// </summary>
    [IsoId("_HMZMtZ__EfC4Q_xhaK1hdQ")]
    [DisplayName("White List Identification")]
    [IsoXmlTag("WhtListId")]
    public PointOfInteraction6? WhiteListIdentification { get; init; }
}
