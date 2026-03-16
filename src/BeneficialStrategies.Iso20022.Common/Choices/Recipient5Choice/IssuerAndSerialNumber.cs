// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient5Choice
{
    /// <summary>
    /// Certificate issuer name and serial number (see ITU X.509).
    /// </summary>
    [IsoId("_HdnNoGi1EeS87LmvcA55sg")]
    [DisplayName("Issuer And Serial Number")]
    public record IssuerAndSerialNumber : Recipient5Choice_
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
}
