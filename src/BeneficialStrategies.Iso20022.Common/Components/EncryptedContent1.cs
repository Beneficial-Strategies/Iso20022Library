// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted data with an encryption key.
/// </summary>
[IsoId("_Sw1NtwEcEeCQm6a_G2yO_w_594420368")]
[DisplayName("Encrypted Content")]
public record EncryptedContent1
{
    /// <summary>
    /// Type of data which have been encrypted.
    /// </summary>
    [IsoId("_Sw1NuAEcEeCQm6a_G2yO_w_942205633")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType1Code ContentType { get; init; }

    /// <summary>
    /// Algorithm used to encrypt the data.
    /// </summary>
    [IsoId("_Sw1NuQEcEeCQm6a_G2yO_w_-961449221")]
    [DisplayName("Content Encryption Algorithm")]
    [IsoXmlTag("CnttNcrptnAlgo")]
    public required AlgorithmIdentification1 ContentEncryptionAlgorithm { get; init; }

    /// <summary>
    /// Encrypted data, result of the content encryption.
    /// </summary>
    [IsoId("_Sw1NugEcEeCQm6a_G2yO_w_2006694830")]
    [DisplayName("Encrypted Data")]
    [IsoXmlTag("NcrptdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public required IsoMax10000Binary EncryptedData { get; init; }
}
