// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient8Choice
{
    /// <summary>
    /// Encryption key using previously distributed asymmetric public key.
    /// </summary>
    [IsoId("_EE9KgQxqEeqdx6buGpCCQw")]
    [DisplayName("Key Transport")]
    [IsoXmlTag("KeyTrnsprt")]
    public record KeyTransport : Recipient8Choice_
    {
        /// <summary>
        /// Version of the data structure.
        /// </summary>
        [IsoId("_zpMM8ds2Eee9e6xduATmQg")]
        [DisplayName("Version")]
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Version { get; init; }

        /// <summary>
        /// Identification of a cryptographic asymmetric key for the recipient.
        /// </summary>
        [IsoId("_zpMM89s2Eee9e6xduATmQg")]
        [DisplayName("Recipient Identification")]
        [IsoXmlTag("RcptId")]
        public required Recipient5Choice_ RecipientIdentification { get; init; }

        /// <summary>
        /// Algorithm to encrypt the key encryption key (KEK).
        /// </summary>
        [IsoId("_zpMM9ds2Eee9e6xduATmQg")]
        [DisplayName("Key Encryption Algorithm")]
        [IsoXmlTag("KeyNcrptnAlgo")]
        public required AlgorithmIdentification19 KeyEncryptionAlgorithm { get; init; }

        /// <summary>
        /// Encrypted key encryption key (KEK).
        /// </summary>
        [IsoId("_zpMM99s2Eee9e6xduATmQg")]
        [DisplayName("Encrypted Key")]
        [IsoXmlTag("NcrptdKey")]
        [IsoSimpleType(IsoSimpleType.Max5000Binary)]
        public required IsoMax5000Binary EncryptedKey { get; init; }
    }
}
