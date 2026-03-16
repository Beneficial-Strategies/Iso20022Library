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
[IsoId("_Zacc8XI0Ee299ZbWCkdR_w")]
[DisplayName("Certificate Management Response")]
public record CertificateManagementResponse3
{
    /// <summary>
    /// Identification of the terminal or system using the certificate management service.
    /// </summary>
    [IsoId("_Zhe5EXI0Ee299ZbWCkdR_w")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification176 POIIdentification { get; init; }

    /// <summary>
    /// Identification of the TM or the MTM providing the Certificate Authority service.
    /// </summary>
    [IsoId("_Zhe5E3I0Ee299ZbWCkdR_w")]
    [DisplayName("TM Identification")]
    [IsoXmlTag("TMId")]
    public GenericIdentification176? TMIdentification { get; init; }

    /// <summary>
    /// Requested certificate management service.
    /// </summary>
    [IsoId("_Zhe5FXI0Ee299ZbWCkdR_w")]
    [DisplayName("Certificate Service")]
    [IsoXmlTag("CertSvc")]
    public required CardPaymentServiceType10Code CertificateService { get; init; }

    /// <summary>
    /// Outcome of the certificate service processing.
    /// </summary>
    [IsoId("_Zhe5F3I0Ee299ZbWCkdR_w")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public required ResponseType6 Result { get; init; }

    /// <summary>
    /// Identification of the security profile, for creation, renewal or revocation of certificate.
    /// </summary>
    [IsoId("_Zhe5GXI0Ee299ZbWCkdR_w")]
    [DisplayName("Security Profile")]
    [IsoXmlTag("SctyPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SecurityProfile { get; init; }

    /// <summary>
    /// Challenge value sends by the POI to be received back in a message response.
    /// </summary>
    [IsoId("_dcdrcHI1Ee299ZbWCkdR_w")]
    [DisplayName("POI Challenge Value")]
    [IsoXmlTag("POIChllngVal")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public required IsoMax140Binary POIChallengeValue { get; init; }

    /// <summary>
    /// Date and Time of the TMS.
    /// </summary>
    [IsoId("_-rifcHI1Ee299ZbWCkdR_w")]
    [DisplayName("TMS Date Time")]
    [IsoXmlTag("TMSDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TMSDateTime { get; init; }

    /// <summary>
    /// Created or renewed certificate. The certificate is ASN.1/DER encoded.
    /// </summary>
    [IsoId("_Zhe5G3I0Ee299ZbWCkdR_w")]
    [DisplayName("Client Certificate")]
    [IsoXmlTag("ClntCert")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? ClientCertificate { get; init; }

    /// <summary>
    /// Certificate of the client certificate path, from the CA (Certificate Authority) certificate, to the root certificate, for renewal or revocation of certificate.
    /// </summary>
    [IsoId("_ZhhVUXI0Ee299ZbWCkdR_w")]
    [DisplayName("Client Certificate Path")]
    [IsoXmlTag("ClntCertPth")]
    public SimpleValueList<IsoMax10KBinary> ClientCertificatePath { get; init; } = [];

    /// <summary>
    /// Certificate of the server certificate path, from the CA (Certificate Authority) certificate, to the root certificate, for renewal or revocation of certificate.
    /// </summary>
    [IsoId("_ZhhVU3I0Ee299ZbWCkdR_w")]
    [DisplayName("Server Certificate Path")]
    [IsoXmlTag("SvrCertPth")]
    public SimpleValueList<IsoMax10KBinary> ServerCertificatePath { get; init; } = [];
}
