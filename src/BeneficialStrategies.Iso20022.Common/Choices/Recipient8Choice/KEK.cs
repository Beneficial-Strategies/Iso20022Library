// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient8Choice
{
    /// <summary>
    /// Key encryption key using previously distributed symmetric key.
    /// </summary>
    [IsoId("_EE9KgwxqEeqdx6buGpCCQw")]
    [DisplayName("KEK")]
    [IsoXmlTag("KEK")]
    public record KEK : Recipient8Choice_
    {
        /// <summary>
        /// Version of the data structure.
        /// </summary>
        [IsoId("_ByuFQQ0yEeqUVL7sB4m7NA")]
        [DisplayName("Version")]
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Version { get; init; }

        /// <summary>
        /// Identification of the key encryption key (KEK).
        /// </summary>
        [IsoId("_ByuFQw0yEeqUVL7sB4m7NA")]
        [DisplayName("KEK Identification")]
        [IsoXmlTag("KEKId")]
        public required KEKIdentifier2 KEKIdentification { get; init; }

        /// <summary>
        /// Algorithm to encrypt the key encryption key (KEK).
        /// </summary>
        [IsoId("_ByuFRQ0yEeqUVL7sB4m7NA")]
        [DisplayName("Key Encryption Algorithm")]
        [IsoXmlTag("KeyNcrptnAlgo")]
        public required AlgorithmIdentification29 KeyEncryptionAlgorithm { get; init; }

        /// <summary>
        /// Encrypted key encryption key (KEK).
        /// </summary>
        [IsoId("_ByuFRw0yEeqUVL7sB4m7NA")]
        [DisplayName("Encrypted Key")]
        [IsoXmlTag("NcrptdKey")]
        [IsoSimpleType(IsoSimpleType.Max500Binary)]
        public required IsoMax500Binary EncryptedKey { get; init; }
    }
}
