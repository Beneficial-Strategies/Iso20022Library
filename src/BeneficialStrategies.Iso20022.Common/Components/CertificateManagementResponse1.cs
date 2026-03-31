// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the result of the certificate management request.
/// </summary>
[IsoId("_PATyUI4WEeW6h7rGyYlyTg")]
[DisplayName("Certificate Management Response")]
public record CertificateManagementResponse1
{
    /// <summary>
    /// Identification of the terminal or system using the certificate management service.
    /// </summary>
    [IsoId("_YYXG0I4WEeW6h7rGyYlyTg")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification72 POIIdentification { get; init; }

    /// <summary>
    /// Identification of the TM or the MTM providing the Certificate Authority service.
    /// </summary>
    [IsoId("_v0VpEI4WEeW6h7rGyYlyTg")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public GenericIdentification72? TMIdentification { get; init; }

    /// <summary>
    /// Requested certificate management service.
    /// </summary>
    [IsoId("_-d3eQI4WEeW6h7rGyYlyTg")]
    [DisplayName("Certificate Service")]
    [IsoXmlTag("CertSvc")]
    public required CardPaymentServiceType10Code CertificateService { get; init; }

    /// <summary>
    /// Outcome of the certificate service processing.
    /// </summary>
    [IsoId("_rtjvAI4YEeW6h7rGyYlyTg")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required ResponseType6 Result { get; init; }

    /// <summary>
    /// Identification of the security profile, for creation, renewal or revocation of certificate.
    /// </summary>
    [IsoId("_w4KLoI4YEeW6h7rGyYlyTg")]
    [DisplayName("Security Profile")]
    [IsoXmlTag("SctyPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SecurityProfile { get; init; }

    /// <summary>
    /// Created or renewed certificate. The certificate is ASN.1/DER encoded.
    /// </summary>
    [IsoId("_05Ki8I4YEeW6h7rGyYlyTg")]
    [DisplayName("Client Certificate")]
    [IsoXmlTag("ClntCert")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? ClientCertificate { get; init; }

    /// <summary>
    /// Certificate of the client certificate path, from the CA (Certificate Authority) certificate, to the root certificate, for renewal or revocation of certificate.
    /// </summary>
    [IsoId("_9dIIEI4YEeW6h7rGyYlyTg")]
    [DisplayName("Client Certificate Path")]
    [IsoXmlTag("ClntCertPth")]
    public SimpleValueList<IsoMax10KBinary> ClientCertificatePath { get; init; } = [];

    /// <summary>
    /// Certificate of the server certificate path, from the CA (Certificate Authority) certificate, to the root certificate, for renewal or revocation of certificate.
    /// </summary>
    [IsoId("_EGwHcI4ZEeW6h7rGyYlyTg")]
    [DisplayName("Server Certificate Path")]
    [IsoXmlTag("SvrCertPth")]
    public SimpleValueList<IsoMax10KBinary> ServerCertificatePath { get; init; } = [];
}
