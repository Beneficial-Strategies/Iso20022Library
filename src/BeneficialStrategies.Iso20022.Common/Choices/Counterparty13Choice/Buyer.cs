// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Counterparty13Choice
{
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_9jKai9LCEeiN28wlpBQScw")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public record Buyer : Counterparty13Choice_
    {
        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_7pKzA9LCEeiN28wlpBQScw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required PartyIdentification120Choice_ Identification { get; init; }

        /// <summary>
        /// Legal Entity Identification as an alternate identification for a party.
        /// </summary>
        [IsoId("_7pKzC9LCEeiN28wlpBQScw")]
        [DisplayName("LEI")]
        [IsoXmlTag("LEI")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? LEI { get; init; }

        /// <summary>
        /// Alternate identification for a party.
        /// </summary>
        [IsoId("_7pKzDdLCEeiN28wlpBQScw")]
        [DisplayName("Alternate Identification")]
        [IsoXmlTag("AltrnId")]
        public AlternatePartyIdentification7? AlternateIdentification { get; init; }

        /// <summary>
        /// Account to or from which a securities entry is made.
        /// </summary>
        [IsoId("_7pKzFdLCEeiN28wlpBQScw")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        public SecuritiesAccount19? SafekeepingAccount { get; init; }

        /// <summary>
        /// Date/time at which the instruction was processed by the specified party.
        /// </summary>
        [IsoId("_7pKzHdLCEeiN28wlpBQScw")]
        [DisplayName("Processing Date")]
        [IsoXmlTag("PrcgDt")]
        public DateAndDateTime2Choice_? ProcessingDate { get; init; }

        /// <summary>
        /// Unambiguous identification of the transaction for the party identified.
        /// </summary>
        [IsoId("_7pKzJdLCEeiN28wlpBQScw")]
        [DisplayName("Processing Identification")]
        [IsoXmlTag("PrcgId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ProcessingIdentification { get; init; }

        /// <summary>
        /// Provides additional information to a party identification.
        /// </summary>
        [IsoId("_7pKzLdLCEeiN28wlpBQScw")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public PartyTextInformation1? AdditionalInformation { get; init; }
    }
}
