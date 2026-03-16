// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Counterparty11Choice
{
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_N-0Zm65YEeey8N0JWnVPUw")]
    [DisplayName("Buyer")]
    public record Buyer : Counterparty11Choice_
    {
        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_Nqbd865YEeey8N0JWnVPUw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required PartyIdentification71Choice_ Identification { get; init; }

        /// <summary>
        /// Legal Entity Identification as an alternate identification for a party.
        /// </summary>
        [IsoId("_Nqbd-65YEeey8N0JWnVPUw")]
        [DisplayName("LEI")]
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LEI { get; init; }

        /// <summary>
        /// Alternate identification for a party.
        /// </summary>
        [IsoId("_Nqbd_a5YEeey8N0JWnVPUw")]
        [DisplayName("Alternate Identification")]
        [IsoXmlTag("AltrnId")]
        public AlternatePartyIdentification7? AlternateIdentification { get; init; }

        /// <summary>
        /// Account to or from which a securities entry is made.
        /// </summary>
        [IsoId("_NqbeBa5YEeey8N0JWnVPUw")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        public SecuritiesAccount19? SafekeepingAccount { get; init; }

        /// <summary>
        /// Date/time at which the instruction was processed by the specified party.
        /// </summary>
        [IsoId("_NqbeDa5YEeey8N0JWnVPUw")]
        [DisplayName("Processing Date")]
        [IsoXmlTag("PrcgDt")]
        public DateAndDateTime2Choice_? ProcessingDate { get; init; }

        /// <summary>
        /// Unambiguous identification of the transaction for the party identified.
        /// </summary>
        [IsoId("_NqbeFa5YEeey8N0JWnVPUw")]
        [DisplayName("Processing Identification")]
        [IsoXmlTag("PrcgId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ProcessingIdentification { get; init; }

        /// <summary>
        /// Provides additional information to a party identification.
        /// </summary>
        [IsoId("_NqbeHa5YEeey8N0JWnVPUw")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public PartyTextInformation1? AdditionalInformation { get; init; }
    }
}
