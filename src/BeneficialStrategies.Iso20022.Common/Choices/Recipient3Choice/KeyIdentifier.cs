// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient3Choice
{
    /// <summary>
    /// Identification of a cryptographic symetric key, previously exchanged between the initiator and the recipient.
    /// </summary>
    [IsoId("_c8uDQFc0EeOi-M6GtW0vCQ")]
    [DisplayName("Key Identifier")]
    public record KeyIdentifier : Recipient3Choice_
    {
        /// <summary>
        /// Identification of the cryptographic key.
        /// </summary>
        [IsoId("_Sw1NvAEcEeCQm6a_G2yO_w_-1402944648")]
        [DisplayName("Key Identification")]
        [IsoXmlTag("KeyId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public required IsoMax140Text KeyIdentification { get; init; }

        /// <summary>
        /// Version of the cryptographic key.
        /// </summary>
        [IsoId("_Sw1NvQEcEeCQm6a_G2yO_w_-792542720")]
        [DisplayName("Key Version")]
        [IsoXmlTag("KeyVrsn")]
        [IsoSimpleType(IsoSimpleType.Exact10Text)]
        public required IsoExact10Text KeyVersion { get; init; }

        /// <summary>
        /// Identification used for derivation of a unique key from a master key provided for the data protection.
        /// </summary>
        [IsoId("_Sw1NvgEcEeCQm6a_G2yO_w_-1001700130")]
        [DisplayName("Derivation Identification")]
        [IsoXmlTag("DerivtnId")]
        [IsoSimpleType(IsoSimpleType.Min5Max16Binary)]
        public IsoMin5Max16Binary? DerivationIdentification { get; init; }
    }
}
