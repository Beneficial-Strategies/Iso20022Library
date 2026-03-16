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
[IsoId("_kPJ2gQ0tEeqUVL7sB4m7NA")]
[DisplayName("Encrypted Content")]
public record EncryptedContent6
{
    /// <summary>
    /// Type of data which have been encrypted.
    /// </summary>
    [IsoId("_kbu58Q0tEeqUVL7sB4m7NA")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; }

    /// <summary>
    /// Algorithm used to encrypt the data.
    /// </summary>
    [IsoId("_kbu58w0tEeqUVL7sB4m7NA")]
    [DisplayName("Content Encryption Algorithm")]
    [IsoXmlTag("CnttNcrptnAlgo")]
    public AlgorithmIdentification29? ContentEncryptionAlgorithm { get; init; }

    /// <summary>
    /// Encrypted data, result of the content encryption.
    /// </summary>
    [IsoId("_kbu59Q0tEeqUVL7sB4m7NA")]
    [DisplayName("Encrypted Data")]
    [IsoXmlTag("NcrptdData")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public required IsoMax100KBinary EncryptedData { get; init; }
}
