// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification11Choice
{
    /// <summary>
    /// An infrastructure that is very often a component of a clearinghouse, and facilitates clearing and settlement for its members by standing between the buyer and the seller of a trade. It may net transactions, and substitutes itself as a settlement counterparty to each position.
    /// </summary>
    [IsoId("_QRnScdp-Ed-ak6NoX_4Aeg_-18000759")]
    [DisplayName("Central Counterparty")]
    public record CentralCounterparty : PartyIdentification11Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Market Identifier Code. The identification of a financial market, as stipulated in the norm ISO 10383 &apos;Codes for exchanges and market identifications&apos;.
        /// </summary>
        [IsoXmlTag("CntrlCtrPty")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public required IsoMICIdentifier Value { get; init; }
    }
}
