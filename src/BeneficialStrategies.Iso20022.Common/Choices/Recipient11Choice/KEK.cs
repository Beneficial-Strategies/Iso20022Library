// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient11Choice
{
    /// <summary>
    /// Key encryption key using previously distributed symmetric key.
    /// </summary>
    [IsoId("_6trNg1E0EeyApZmLzm74zA")]
    [DisplayName("KEK")]
    public record KEK : Recipient11Choice_
    {
        /// <summary>
        /// Version of the data structure.
        /// </summary>
        [IsoId("_pFNiAVE0EeyApZmLzm74zA")]
        [DisplayName("Version")]
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Version { get; init; }

        /// <summary>
        /// Identification of the key encryption key (KEK).
        /// </summary>
        [IsoId("_pFNiA1E0EeyApZmLzm74zA")]
        [DisplayName("KEK Identification")]
        [IsoXmlTag("KEKId")]
        public required KEKIdentifier7 KEKIdentification { get; init; }

        /// <summary>
        /// Algorithm to encrypt the key encryption key (KEK).
        /// </summary>
        [IsoId("_pFNiBVE0EeyApZmLzm74zA")]
        [DisplayName("Key Encryption Algorithm")]
        [IsoXmlTag("KeyNcrptnAlgo")]
        public required AlgorithmIdentification29 KeyEncryptionAlgorithm { get; init; }

        /// <summary>
        /// Encrypted key encryption key (KEK).
        /// </summary>
        [IsoId("_pFNiB1E0EeyApZmLzm74zA")]
        [DisplayName("Encrypted Key")]
        [IsoXmlTag("NcrptdKey")]
        [IsoSimpleType(IsoSimpleType.Max500Binary)]
        public IsoMax500Binary? EncryptedKey { get; init; }
    }
}
