// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digital signatures of data from one or several signers.
/// </summary>
[IsoId("_pJWu0S80Eeu125Ip9zFcsQ")]
[DisplayName("Signed Data")]
public record SignedData6
{
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_pV6kIS80Eeu125Ip9zFcsQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Identification of digest algorithm applied before signature.
    /// </summary>
    [IsoId("_pV6kIy80Eeu125Ip9zFcsQ")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public ValueList<AlgorithmIdentification21> DigestAlgorithm { get; init; } = [];

    /// <summary>
    /// Data to sign.
    /// </summary>
    [IsoId("_pV6kJS80Eeu125Ip9zFcsQ")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public EncapsulatedContent3? EncapsulatedContent { get; init; }

    /// <summary>
    /// Chain of X.509 certificates.
    /// </summary>
    [IsoId("_pV6kJy80Eeu125Ip9zFcsQ")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public SimpleValueList<IsoMax5000Binary> Certificate { get; init; } = [];

    /// <summary>
    /// Digital signature and identification of a signer.
    /// </summary>
    [IsoId("_pV6kKS80Eeu125Ip9zFcsQ")]
    [DisplayName("Signer")]
    [IsoXmlTag("Sgnr")]
    public ValueList<Signer5> Signer { get; init; } = [];
}
