// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient2Choice
{
    /// <summary>
    /// Encryption key using previously distributed symmetric key.
    /// </summary>
    [IsoId("_E8e4CQioEeKn9O5oyej_zw")]
    [DisplayName("KEK")]
    public record KEK : Recipient2Choice_
    {
        /// <summary>
        /// Version of the cryptographic key.
        /// </summary>
        [IsoId("_pYJZQQinEeKn9O5oyej_zw")]
        [DisplayName("Version")]
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Version { get; init; }

        /// <summary>
        /// Identification of the key encryption key (KEK).
        /// </summary>
        [IsoId("_pYJZRQinEeKn9O5oyej_zw")]
        [DisplayName("KEK Identification")]
        [IsoXmlTag("KEKId")]
        public required KEKIdentifier1 KEKIdentification { get; init; }

        /// <summary>
        /// Algorithm to encrypt the key encryption key (KEK).
        /// </summary>
        [IsoId("_pYJZSQinEeKn9O5oyej_zw")]
        [DisplayName("Key Encryption Algorithm")]
        [IsoXmlTag("KeyNcrptnAlgo")]
        public required AlgorithmIdentification2 KeyEncryptionAlgorithm { get; init; }

        /// <summary>
        /// Encrypted key encryption key (KEK).
        /// </summary>
        [IsoId("_pYJZTQinEeKn9O5oyej_zw")]
        [DisplayName("Encrypted Key")]
        [IsoXmlTag("NcrptdKey")]
        [IsoSimpleType(IsoSimpleType.Max140Binary)]
        public required IsoMax140Binary EncryptedKey { get; init; }
    }
}
