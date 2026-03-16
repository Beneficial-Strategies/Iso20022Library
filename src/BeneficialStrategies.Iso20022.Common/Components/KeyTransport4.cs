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
[IsoId("_e-hIoWi0EeS87LmvcA55sg")]
[DisplayName("Key Transport")]
public record KeyTransport4
{
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_fLktMWi0EeS87LmvcA55sg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Identification of a cryptographic asymmetric key for the recipient.
    /// </summary>
    [IsoId("_fLktM2i0EeS87LmvcA55sg")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public required Recipient5Choice_ RecipientIdentification { get; init; }

    /// <summary>
    /// Algorithm to encrypt the key encryption key (KEK).
    /// </summary>
    [IsoId("_fLktNWi0EeS87LmvcA55sg")]
    [DisplayName("Key Encryption Algorithm")]
    [IsoXmlTag("KeyNcrptnAlgo")]
    public required AlgorithmIdentification11 KeyEncryptionAlgorithm { get; init; }

    /// <summary>
    /// Encrypted key encryption key (KEK).
    /// </summary>
    [IsoId("_fLktN2i0EeS87LmvcA55sg")]
    [DisplayName("Encrypted Key")]
    [IsoXmlTag("NcrptdKey")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    public required IsoMax5000Binary EncryptedKey { get; init; }
}
