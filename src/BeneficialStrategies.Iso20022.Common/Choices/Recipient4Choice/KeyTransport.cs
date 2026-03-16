// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient4Choice
{
    /// <summary>
    /// Encryption key using previously distributed asymmetric public key.
    /// </summary>
    [IsoId("_N1aSoWi0EeS87LmvcA55sg")]
    [DisplayName("Key Transport")]
    public record KeyTransport : Recipient4Choice_
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
}
