// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Counterparty15Choice
{
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_t9laCyqDEeyR9JrVGfaMKw")]
    [DisplayName("Buyer")]
    public record Buyer : Counterparty15Choice_
    {
        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_sd6XAyqDEeyR9JrVGfaMKw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required PartyIdentification120Choice_ Identification { get; init; }

        /// <summary>
        /// Legal Entity Identification as an alternate identification for a party.
        /// </summary>
        [IsoId("_sd6XCyqDEeyR9JrVGfaMKw")]
        [DisplayName("LEI")]
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LEI { get; init; }

        /// <summary>
        /// Alternate identification for a party.
        /// </summary>
        [IsoId("_sd6XDSqDEeyR9JrVGfaMKw")]
        [DisplayName("Alternate Identification")]
        [IsoXmlTag("AltrnId")]
        public AlternatePartyIdentification7? AlternateIdentification { get; init; }

        /// <summary>
        /// Account to or from which a securities entry is made.
        /// </summary>
        [IsoId("_sd6XFSqDEeyR9JrVGfaMKw")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        public SecuritiesAccount19? SafekeepingAccount { get; init; }

        /// <summary>
        /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
        /// </summary>
        [IsoId("_m5noAyqDEeyR9JrVGfaMKw")]
        [DisplayName("Block Chain Address Or Wallet")]
        [IsoXmlTag("BlckChainAdrOrWllt")]
        public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }

        /// <summary>
        /// Date/time at which the instruction was processed by the specified party.
        /// </summary>
        [IsoId("_sd6XHSqDEeyR9JrVGfaMKw")]
        [DisplayName("Processing Date")]
        [IsoXmlTag("PrcgDt")]
        public DateAndDateTime2Choice_? ProcessingDate { get; init; }

        /// <summary>
        /// Unambiguous identification of the transaction for the party identified.
        /// </summary>
        [IsoId("_sd6XJSqDEeyR9JrVGfaMKw")]
        [DisplayName("Processing Identification")]
        [IsoXmlTag("PrcgId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ProcessingIdentification { get; init; }

        /// <summary>
        /// Provides additional information to a party identification.
        /// </summary>
        [IsoId("_sd6XLSqDEeyR9JrVGfaMKw")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public PartyTextInformation1? AdditionalInformation { get; init; }
    }
}
