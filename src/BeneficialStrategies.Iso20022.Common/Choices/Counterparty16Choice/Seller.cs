// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Counterparty16Choice
{
    /// <summary>
    /// Party that sells goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_c69UxTi8Eeydid5dcNPKvg")]
    [DisplayName("Seller")]
    public record Seller : Counterparty16Choice_
    {
        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_cego6Ti8Eeydid5dcNPKvg")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required PartyIdentification137Choice_ Identification { get; init; }

        /// <summary>
        /// Legal Entity Identification as an alternate identification for a party.
        /// </summary>
        [IsoId("_cego8Ti8Eeydid5dcNPKvg")]
        [DisplayName("LEI")]
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LEI { get; init; }

        /// <summary>
        /// Alternate identification for a party.
        /// </summary>
        [IsoId("_cego8zi8Eeydid5dcNPKvg")]
        [DisplayName("Alternate Identification")]
        [IsoXmlTag("AltrnId")]
        public AlternatePartyIdentification9? AlternateIdentification { get; init; }

        /// <summary>
        /// Account to or from which a securities entry is made.
        /// </summary>
        [IsoId("_cego-zi8Eeydid5dcNPKvg")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        public SecuritiesAccount30? SafekeepingAccount { get; init; }

        /// <summary>
        /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
        /// </summary>
        [IsoId("_cegpAzi8Eeydid5dcNPKvg")]
        [DisplayName("Block Chain Address Or Wallet")]
        [IsoXmlTag("BlckChainAdrOrWllt")]
        public BlockChainAddressWallet7? BlockChainAddressOrWallet { get; init; }

        /// <summary>
        /// Date/time at which the instruction was processed by the specified party.
        /// </summary>
        [IsoId("_cegpBTi8Eeydid5dcNPKvg")]
        [DisplayName("Processing Date")]
        [IsoXmlTag("PrcgDt")]
        public DateAndDateTime2Choice_? ProcessingDate { get; init; }

        /// <summary>
        /// Unambiguous identification of the transaction for the party identified.
        /// </summary>
        [IsoId("_cegpDTi8Eeydid5dcNPKvg")]
        [DisplayName("Processing Identification")]
        [IsoXmlTag("PrcgId")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
        [StringLength(maximumLength: 16, MinimumLength = 1)]
        public IsoRestrictedFINXMax16Text? ProcessingIdentification { get; init; }

        /// <summary>
        /// Provides additional information to a party identification.
        /// </summary>
        [IsoId("_cegpFTi8Eeydid5dcNPKvg")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public PartyTextInformation3? AdditionalInformation { get; init; }
    }
}
