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
[IsoId("_v-VR0aQtEeeWXKXf3KjtmQ")]
[DisplayName("Encrypted Content")]
public record EncryptedContent5
{
    /// <summary>
    /// Type of data which have been encrypted.
    /// </summary>
    [IsoId("_wJoi4aQtEeeWXKXf3KjtmQ")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; }

    /// <summary>
    /// Algorithm used to encrypt the data.
    /// </summary>
    [IsoId("_wJoi46QtEeeWXKXf3KjtmQ")]
    [DisplayName("Content Encryption Algorithm")]
    [IsoXmlTag("CnttNcrptnAlgo")]
    public required AlgorithmIdentification25 ContentEncryptionAlgorithm { get; init; }

    /// <summary>
    /// Encrypted data, result of the content encryption.
    /// </summary>
    [IsoId("_wJoi5aQtEeeWXKXf3KjtmQ")]
    [DisplayName("Encrypted Data Element")]
    [IsoXmlTag("NcrptdDataElmt")]
    public ValueList<EncryptedDataElement1> EncryptedDataElement { get; init; } = [];
    // ID for the above is _wJoi5aQtEeeWXKXf3KjtmQ
}
