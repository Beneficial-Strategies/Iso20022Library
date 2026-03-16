// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient7Choice
{
    /// <summary>
    /// Key encryption key using previously distributed symmetric key.
    /// </summary>
    [IsoId("__Mbdw6RbEeeWXKXf3KjtmQ")]
    [DisplayName("KEK")]
    [IsoXmlTag("KEK")]
    public record KEK : Recipient7Choice_
    {
        /// <summary>
        /// Version of the data structure.
        /// </summary>
        [IsoId("_tyiNsdZ3EeeA4_YxLuyJaA")]
        [DisplayName("Version")]
        [IsoXmlTag("Vrsn")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? Version { get; init; }

        /// <summary>
        /// Identification of the key encryption key (KEK).
        /// </summary>
        [IsoId("_tyiNs9Z3EeeA4_YxLuyJaA")]
        [DisplayName("KEK Identification")]
        [IsoXmlTag("KEKId")]
        public required KEKIdentifier6 KEKIdentification { get; init; }

        /// <summary>
        /// Algorithm to encrypt the key encryption key (KEK).
        /// </summary>
        [IsoId("_tyiNtdZ3EeeA4_YxLuyJaA")]
        [DisplayName("Key Encryption Algorithm")]
        [IsoXmlTag("KeyNcrptnAlgo")]
        public required AlgorithmIdentification28 KeyEncryptionAlgorithm { get; init; }

        /// <summary>
        /// Encrypted key encryption key (KEK).
        /// </summary>
        [IsoId("_tyiNt9Z3EeeA4_YxLuyJaA")]
        [DisplayName("Encrypted Key")]
        [IsoXmlTag("NcrptdKey")]
        [IsoSimpleType(IsoSimpleType.Max500Binary)]
        public IsoMax500Binary? EncryptedKey { get; init; }
    }
}
