// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient1Choice
{
    /// <summary>
    /// Encryption key using previously distributed asymmetric key.
    /// </summary>
    [IsoId("_SxIvvAEcEeCQm6a_G2yO_w_-1700784430")]
    [DisplayName("Key Transport")]
    [IsoXmlTag("KeyTrnsprt")]
    public record KeyTransport : Recipient1Choice_
    {
        /// <summary>
        /// Version of the cryptographic key.
        /// </summary>
        [IsoId("_SxIvtwEcEeCQm6a_G2yO_w_-613325981")]
        [DisplayName("Version")]
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Version { get; init; }

        /// <summary>
        /// Transport key or key encryption key (KEK) for the recipient.
        /// </summary>
        [IsoId("_SxIvuAEcEeCQm6a_G2yO_w_-69977673")]
        [DisplayName("Recipient Identification")]
        [IsoXmlTag("RcptId")]
        public required CertificateIdentifier1 RecipientIdentification { get; init; }

        /// <summary>
        /// Algorithm to encrypt the key encryption key (KEK).
        /// </summary>
        [IsoId("_SxIvuQEcEeCQm6a_G2yO_w_-1927066470")]
        [DisplayName("Key Encryption Algorithm")]
        [IsoXmlTag("KeyNcrptnAlgo")]
        public required AlgorithmIdentification1 KeyEncryptionAlgorithm { get; init; }

        /// <summary>
        /// Encrypted key encryption key (KEK).
        /// </summary>
        [IsoId("_SxIvugEcEeCQm6a_G2yO_w_1961976925")]
        [DisplayName("Encrypted Key")]
        [IsoXmlTag("NcrptdKey")]
        [IsoSimpleType(IsoSimpleType.Max140Binary)]
        public required IsoMax140Binary EncryptedKey { get; init; }
    }
}
