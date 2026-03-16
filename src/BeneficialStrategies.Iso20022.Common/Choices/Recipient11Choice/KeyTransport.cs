// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient11Choice
{
    /// <summary>
    /// Encryption key using previously distributed asymmetric public key.
    /// </summary>
    [IsoId("_6trNgVE0EeyApZmLzm74zA")]
    [DisplayName("Key Transport")]
    public record KeyTransport : Recipient11Choice_
    {
        /// <summary>
        /// Version of the data structure.
        /// </summary>
        [IsoId("_feZ90VFKEeyApZmLzm74zA")]
        [DisplayName("Version")]
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Version { get; init; }

        /// <summary>
        /// Identification of a cryptographic asymmetric key for the recipient.
        /// </summary>
        [IsoId("_feZ901FKEeyApZmLzm74zA")]
        [DisplayName("Recipient Identification")]
        [IsoXmlTag("RcptId")]
        public required Recipient12Choice_ RecipientIdentification { get; init; }

        /// <summary>
        /// Algorithm to encrypt the key encryption key (KEK).
        /// </summary>
        [IsoId("_feZ91VFKEeyApZmLzm74zA")]
        [DisplayName("Key Encryption Algorithm")]
        [IsoXmlTag("KeyNcrptnAlgo")]
        public required AlgorithmIdentification19 KeyEncryptionAlgorithm { get; init; }

        /// <summary>
        /// Encrypted key encryption key (KEK).
        /// </summary>
        [IsoId("_feZ911FKEeyApZmLzm74zA")]
        [DisplayName("Encrypted Key")]
        [IsoXmlTag("NcrptdKey")]
        [IsoSimpleType(IsoSimpleType.Max5000Binary)]
        public required IsoMax5000Binary EncryptedKey { get; init; }
    }
}
