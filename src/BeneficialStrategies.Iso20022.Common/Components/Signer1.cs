// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity who has signed the data and its digital signature.
/// </summary>
[IsoId("_SwZI3gEcEeCQm6a_G2yO_w_1551867315")]
[DisplayName("Signer")]
public record Signer1
{
    /// <summary>
    /// Version of the Cryptographic Message Syntax (CMS) data structure.
    /// </summary>
    [IsoId("_SwiSwAEcEeCQm6a_G2yO_w_-1171239652")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Identification of the entity who has signed the data.
    /// </summary>
    [IsoId("_SwiSwQEcEeCQm6a_G2yO_w_-1811354197")]
    [DisplayName("Signer Identification")]
    [IsoXmlTag("SgnrId")]
    public required CertificateIdentifier1 SignerIdentification { get; init; }

    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    [IsoId("_SwiSwgEcEeCQm6a_G2yO_w_1626623909")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public required AlgorithmIdentification1 DigestAlgorithm { get; init; }

    /// <summary>
    /// Cryptographic digital signature algorithm.
    /// </summary>
    [IsoId("_SwiSwwEcEeCQm6a_G2yO_w_-394431726")]
    [DisplayName("Signature Algorithm")]
    [IsoXmlTag("SgntrAlgo")]
    public required AlgorithmIdentification1 SignatureAlgorithm { get; init; }

    /// <summary>
    /// Digital signature.
    /// </summary>
    [IsoId("_SwiSxAEcEeCQm6a_G2yO_w_-1531851906")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max500Binary)]
    public required IsoMax500Binary Signature { get; init; }
}
