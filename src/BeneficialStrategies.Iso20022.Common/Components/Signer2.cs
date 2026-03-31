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
[IsoId("_6sFCYQirEeKn9O5oyej_zw")]
[DisplayName("Signer")]
public record Signer2
{
    /// <summary>
    /// Version of the Cryptographic Message Syntax (CMS) data structure.
    /// </summary>
    [IsoId("_63-wYQirEeKn9O5oyej_zw")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Identification of the entity who has signed the data.
    /// </summary>
    [IsoId("_63-wZQirEeKn9O5oyej_zw")]
    [DisplayName("Signer Identification")]
    [IsoXmlTag("SgnrId")]
    public required CertificateIdentifier1 SignerIdentification { get; init; }

    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    [IsoId("_63-waQirEeKn9O5oyej_zw")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public required AlgorithmIdentification5 DigestAlgorithm { get; init; }

    /// <summary>
    /// Cryptographic digital signature algorithm.
    /// </summary>
    [IsoId("_63-wbQirEeKn9O5oyej_zw")]
    [DisplayName("Signature Algorithm")]
    [IsoXmlTag("SgntrAlgo")]
    public required AlgorithmIdentification4 SignatureAlgorithm { get; init; }

    /// <summary>
    /// Digital signature.
    /// </summary>
    [IsoId("_63-wcQirEeKn9O5oyej_zw")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max500Binary)]
    public required IsoMax500Binary Signature { get; init; }
}
