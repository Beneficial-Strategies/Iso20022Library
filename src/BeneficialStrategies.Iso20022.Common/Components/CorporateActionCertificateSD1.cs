// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Certificate information provided for a given corporate action instruction.
/// </summary>
[IsoId("_OBTl0MViEeeprYdSN88o0Q")]
[DisplayName("Corporate Action Certificate SD")]
public record CorporateActionCertificateSD1
{
    /// <summary>
    /// Unique identification or serial number that is assigned and affixed by an issuer or transfer agent to each securities certificate.
    /// </summary>
    [IsoId("_HsduNMVjEeeprYdSN88o0Q")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    [IsoSimpleType(IsoSimpleType.Max15AlphaNumericText)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public required IsoMax15AlphaNumericText CertificateNumber { get; init; }

    /// <summary>
    /// Additional identifier assigned by DTC.
    /// </summary>
    [IsoId("_kj2zcMVnEeeprYdSN88o0Q")]
    [DisplayName("Certificate Sequence Number")]
    [IsoXmlTag("CertSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max15AlphaNumericText)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public IsoMax15AlphaNumericText? CertificateSequenceNumber { get; init; }

    /// <summary>
    /// Registration name of the beneficial holder.
    /// </summary>
    [IsoId("_uY8pQMVnEeeprYdSN88o0Q")]
    [DisplayName("Certificate Registration Name")]
    [IsoXmlTag("CertRegnNm")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? CertificateRegistrationName { get; init; }
}
