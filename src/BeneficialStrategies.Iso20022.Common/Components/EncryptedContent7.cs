// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted Content7.
/// </summary>
[IsoId("_Teq7UY-HEe6oobnCtR50kw")]
[DisplayName("Encrypted Content7")]
public record EncryptedContent7
{
    /// <summary>
    /// Content Encryption Algorithm.
    /// </summary>
    [DisplayName("Content Encryption Algorithm")]
    [IsoXmlTag("CnttNcrptnAlgo")]
    public AlgorithmIdentification32? ContentEncryptionAlgorithm { get; init; }

    /// <summary>
    /// Content Type.
    /// </summary>
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; }

    /// <summary>
    /// Encrypted Data.
    /// </summary>
    [DisplayName("Encrypted Data")]
    [IsoXmlTag("NcrptdData")]
    public required IsoMax100KBinary EncryptedData { get; init; }
}
