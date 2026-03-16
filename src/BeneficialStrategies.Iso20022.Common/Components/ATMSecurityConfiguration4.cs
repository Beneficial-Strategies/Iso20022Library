// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration of the digital signatures if the security module is able to perform digital signatures with an asymmetric key.
/// </summary>
[IsoId("_u0cgsYr8EeSvuOJS0mmL0g")]
[DisplayName("ATM Security Configuration")]
public record ATMSecurityConfiguration4
{
    /// <summary>
    /// Maximum number of certificates in a certificate path, the security module is able to manage.
    /// </summary>
    [IsoId("_HRDZgIr9EeSvuOJS0mmL0g")]
    [DisplayName("Maximum Certificates")]
    [IsoXmlTag("MaxCerts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumCertificates { get; init; }

    /// <summary>
    /// Maximum number of cosigners, the security module is able to manage in a digital signature.
    /// </summary>
    [IsoId("_LYwOsIr9EeSvuOJS0mmL0g")]
    [DisplayName("Maximum Signatures")]
    [IsoXmlTag("MaxSgntrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumSignatures { get; init; }

    /// <summary>
    /// Digital signature algorithm the security module is able to manage.
    /// </summary>
    [IsoId("_vBzAOYr8EeSvuOJS0mmL0g")]
    [DisplayName("Digital Signature Algorithm")]
    [IsoXmlTag("DgtlSgntrAlgo")]
    public SimpleValueList<Algorithm14Code> DigitalSignatureAlgorithm { get; init; } = [];
}
