// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient6Choice
{
    /// <summary>
    /// Key encryption key using previously distributed symmetric key.
    /// </summary>
    [IsoId("__raos9s2Eee9e6xduATmQg")]
    [DisplayName("KEK")]
    [IsoXmlTag("KEK")]
    public record KEK : Recipient6Choice_
    {
        /// <summary>
        /// Version of the data structure.
        /// </summary>
        [IsoId("_sgtYcdtkEee9e6xduATmQg")]
        [DisplayName("Version")]
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Version { get; init; }

        /// <summary>
        /// Identification of the key encryption key (KEK).
        /// </summary>
        [IsoId("_sgtYc9tkEee9e6xduATmQg")]
        [DisplayName("KEK Identification")]
        [IsoXmlTag("KEKId")]
        public required KEKIdentifier2 KEKIdentification { get; init; }

        /// <summary>
        /// Algorithm to encrypt the key encryption key (KEK).
        /// </summary>
        [IsoId("_sgtYddtkEee9e6xduATmQg")]
        [DisplayName("Key Encryption Algorithm")]
        [IsoXmlTag("KeyNcrptnAlgo")]
        public required AlgorithmIdentification23 KeyEncryptionAlgorithm { get; init; }

        /// <summary>
        /// Encrypted key encryption key (KEK).
        /// </summary>
        [IsoId("_sgtYd9tkEee9e6xduATmQg")]
        [DisplayName("Encrypted Key")]
        [IsoXmlTag("NcrptdKey")]
        [IsoSimpleType(IsoSimpleType.Max500Binary)]
        public required IsoMax500Binary EncryptedKey { get; init; }
    }
}
