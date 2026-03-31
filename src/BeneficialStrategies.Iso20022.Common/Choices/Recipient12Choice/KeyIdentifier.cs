// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient12Choice
{
    /// <summary>
    /// Identifier of a cryptographic asymmetric key, previously exchanged between initiator and recipient.
    /// </summary>
    [IsoId("_TNT_o1FKEeyApZmLzm74zA")]
    [DisplayName("Key Identifier")]
    [IsoXmlTag("KeyIdr")]
    public record KeyIdentifier : Recipient12Choice_
    {
        /// <summary>
        /// Identification of the cryptographic key.
        /// </summary>
        [IsoId("_TT6q0VEyEeyApZmLzm74zA")]
        [DisplayName("Key Identification")]
        [IsoXmlTag("KeyId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public required IsoMax140Text KeyIdentification { get; init; }

        /// <summary>
        /// Version of the cryptographic key.
        /// </summary>
        [IsoId("_TT6q01EyEeyApZmLzm74zA")]
        [DisplayName("Key Version")]
        [IsoXmlTag("KeyVrsn")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public required IsoMax140Text KeyVersion { get; init; }

        /// <summary>
        /// Number of usages of the cryptographic key.
        /// </summary>
        [IsoId("_TT6q1VEyEeyApZmLzm74zA")]
        [DisplayName("Sequence Number")]
        [IsoXmlTag("SeqNb")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? SequenceNumber { get; init; }

        /// <summary>
        /// Identification used for derivation of a unique key from a master key provided for the data protection.
        /// </summary>
        [IsoId("_TT6q11EyEeyApZmLzm74zA")]
        [DisplayName("Derivation Identification")]
        [IsoXmlTag("DerivtnId")]
        [IsoSimpleType(IsoSimpleType.Max500Binary)]
        public IsoMax500Binary? DerivationIdentification { get; init; }
    }
}
