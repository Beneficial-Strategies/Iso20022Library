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
[IsoId("_SUqPAS80Eeu125Ip9zFcsQ")]
[DisplayName("Signer")]
public record Signer5
{
    /// <summary>
    /// Version of the Cryptographic Message Syntax (CMS) data structure.
    /// </summary>
    [IsoId("_ShX1US80Eeu125Ip9zFcsQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Identification of the entity who has signed the data.
    /// </summary>
    [IsoId("_ShX1Uy80Eeu125Ip9zFcsQ")]
    [DisplayName("Signer Identification")]
    [IsoXmlTag("SgnrId")]
    public Recipient9Choice_? SignerIdentification { get; init; }

    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    [IsoId("_ShX1VS80Eeu125Ip9zFcsQ")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public required AlgorithmIdentification21 DigestAlgorithm { get; init; }

    /// <summary>
    /// Collection of attributes that are signed.
    /// </summary>
    [IsoId("_ShX1Vy80Eeu125Ip9zFcsQ")]
    [DisplayName("Signed Attributes")]
    [IsoXmlTag("SgndAttrbts")]
    public GenericInformation1? SignedAttributes { get; init; }

    /// <summary>
    /// Cryptographic digital signature algorithm.
    /// </summary>
    [IsoId("_ShX1WS80Eeu125Ip9zFcsQ")]
    [DisplayName("Signature Algorithm")]
    [IsoXmlTag("SgntrAlgo")]
    public required AlgorithmIdentification30 SignatureAlgorithm { get; init; }

    /// <summary>
    /// Digital signature.
    /// </summary>
    [IsoId("_ShX1Wy80Eeu125Ip9zFcsQ")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public required IsoMax3000Binary Signature { get; init; }
}
