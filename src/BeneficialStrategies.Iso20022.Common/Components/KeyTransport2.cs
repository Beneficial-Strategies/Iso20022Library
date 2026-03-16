// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key encryption key (KEK), encrypted with a previously distributed asymmetric public key.
/// </summary>
[IsoId("_NSPIIQvAEeK6BpGAixa3eA")]
[DisplayName("Key Transport")]
public record KeyTransport2
{
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_NevTEQvAEeK6BpGAixa3eA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Version { get; init; }

    /// <summary>
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    [IsoId("_NevTFQvAEeK6BpGAixa3eA")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public required CertificateIdentifier1 RecipientIdentification { get; init; }

    /// <summary>
    /// Algorithm to encrypt the key encryption key (KEK).
    /// </summary>
    [IsoId("_NevTGQvAEeK6BpGAixa3eA")]
    [DisplayName("Key Encryption Algorithm")]
    [IsoXmlTag("KeyNcrptnAlgo")]
    public required AlgorithmIdentification7 KeyEncryptionAlgorithm { get; init; }

    /// <summary>
    /// Encrypted key encryption key (KEK).
    /// </summary>
    [IsoId("_NevTHQvAEeK6BpGAixa3eA")]
    [DisplayName("Encrypted Key")]
    [IsoXmlTag("NcrptdKey")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public required IsoMax140Binary EncryptedKey { get; init; }
}
