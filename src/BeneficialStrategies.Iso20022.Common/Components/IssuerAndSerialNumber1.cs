// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Certificate issuer name and serial number (see X.509).
/// </summary>
[IsoId("_SxIvsQEcEeCQm6a_G2yO_w_-65882528")]
[DisplayName("Issuer And Serial Number")]
public record IssuerAndSerialNumber1
{
    /// <summary>
    /// Certificate issuer name (see X.509).
    /// </summary>
    [IsoId("_SxIvsgEcEeCQm6a_G2yO_w_1368507280")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required CertificateIssuer1 Issuer { get; init; }

    /// <summary>
    /// Certificate serial number (see X.509).
    /// </summary>
    [IsoId("_SxIvswEcEeCQm6a_G2yO_w_683840175")]
    [DisplayName("Serial Number")]
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    public required IsoMax35Binary SerialNumber { get; init; }
}
