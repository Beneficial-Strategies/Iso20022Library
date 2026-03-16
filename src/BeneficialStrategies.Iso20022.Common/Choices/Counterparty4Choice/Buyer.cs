// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Counterparty4Choice
{
    /// <summary>
    /// Party that buys goods or services, or a financial instrument.
    /// </summary>
    [IsoId("_eaw-Q-aOEd-q8fx_Zl_34A")]
    [DisplayName("Buyer")]
    public record Buyer : Counterparty4Choice_
    {
        /// <summary>
        /// Identification of the party.
        /// </summary>
        [IsoId("_eanNi-aOEd-q8fx_Zl_34A")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required PartyIdentification43Choice_ Identification { get; init; }

        /// <summary>
        /// Alternate identification for a party.
        /// </summary>
        [IsoId("_eanNjeaOEd-q8fx_Zl_34A")]
        [DisplayName("Alternate Identification")]
        [IsoXmlTag("AltrnId")]
        public AlternatePartyIdentification2? AlternateIdentification { get; init; }

        /// <summary>
        /// Account to or from which a securities entry is made.
        /// </summary>
        [IsoId("_eanNj-aOEd-q8fx_Zl_34A")]
        [DisplayName("Safekeeping Account")]
        [IsoXmlTag("SfkpgAcct")]
        public SecuritiesAccount13? SafekeepingAccount { get; init; }

        /// <summary>
        /// Date/time at which the instruction was processed by the specified party.
        /// </summary>
        [IsoId("_eanNkeaOEd-q8fx_Zl_34A")]
        [DisplayName("Processing Date")]
        [IsoXmlTag("PrcgDt")]
        public DateAndDateTimeChoice_? ProcessingDate { get; init; }

        /// <summary>
        /// Unambiguous identification of the transaction for the party identified.
        /// </summary>
        [IsoId("_eanNk-aOEd-q8fx_Zl_34A")]
        [DisplayName("Processing Identification")]
        [IsoXmlTag("PrcgId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ProcessingIdentification { get; init; }

        /// <summary>
        /// Provides additional information to a party identification.
        /// </summary>
        [IsoId("_eanNleaOEd-q8fx_Zl_34A")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public PartyTextInformation1? AdditionalInformation { get; init; }
    }
}
