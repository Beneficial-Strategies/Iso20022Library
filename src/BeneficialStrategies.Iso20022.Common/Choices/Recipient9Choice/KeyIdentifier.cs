// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient9Choice
{
    /// <summary>
    /// Identifier of a cryptographic asymmetric key, previously exchanged between initiator and recipient.
    /// </summary>
    [IsoId("_M0YGAy8jEeu125Ip9zFcsQ")]
    [DisplayName("Key Identifier")]
    [IsoXmlTag("KeyIdr")]
    public record KeyIdentifier : Recipient9Choice_
    {
        /// <summary>
        /// Identification of the cryptographic key.
        /// </summary>
        [IsoId("_RzjGsWi1EeS87LmvcA55sg")]
        [DisplayName("Key Identification")]
        [IsoXmlTag("KeyId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public required IsoMax140Text KeyIdentification { get; init; }

        /// <summary>
        /// Version of the cryptographic key.
        /// </summary>
        [IsoId("_RzjGs2i1EeS87LmvcA55sg")]
        [DisplayName("Key Version")]
        [IsoXmlTag("KeyVrsn")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public required IsoMax140Text KeyVersion { get; init; }

        /// <summary>
        /// Number of usages of the cryptographic key.
        /// </summary>
        [IsoId("_riRHoGi1EeS87LmvcA55sg")]
        [DisplayName("Sequence Number")]
        [IsoXmlTag("SeqNb")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public IsoNumber? SequenceNumber { get; init; }

        /// <summary>
        /// Identification used for derivation of a unique key from a master key provided for the data protection.
        /// </summary>
        [IsoId("_RzjGtWi1EeS87LmvcA55sg")]
        [DisplayName("Derivation Identification")]
        [IsoXmlTag("DerivtnId")]
        [IsoSimpleType(IsoSimpleType.Min5Max16Binary)]
        public IsoMin5Max16Binary? DerivationIdentification { get; init; }
    }
}
