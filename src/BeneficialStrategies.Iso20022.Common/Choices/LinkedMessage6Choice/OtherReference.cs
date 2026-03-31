// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LinkedMessage6Choice
{
    /// <summary>
    /// Linked other reference.
    /// </summary>
    [IsoId("_2-DoMzWhEe2OzdGcZrUAEQ")]
    [DisplayName("Other Reference")]
    [IsoXmlTag("OthrRef")]
    public record OtherReference : LinkedMessage6Choice_
    {
        /// <summary>
        /// Business reference of a message assigned by the party issuing the message. This reference must be unique amongst all messages of the same name sent by the same party.
        /// </summary>
        [IsoId("_3WWMYzWhEe2OzdGcZrUAEQ")]
        [DisplayName("Reference")]
        [IsoXmlTag("Ref")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Reference { get; init; }

        /// <summary>
        /// Issuer of the reference.
        /// </summary>
        [IsoId("_3WWMZTWhEe2OzdGcZrUAEQ")]
        [DisplayName("Reference Issuer")]
        [IsoXmlTag("RefIssr")]
        public PartyIdentification247Choice_? ReferenceIssuer { get; init; }

        /// <summary>
        /// Name of a message.
        /// </summary>
        [IsoId("_3WWMZzWhEe2OzdGcZrUAEQ")]
        [DisplayName("Message Name")]
        [IsoXmlTag("MsgNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MessageName { get; init; }

        /// <summary>
        /// Identification of the type of message.
        /// </summary>
        [IsoId("_EYz9JDWiEe2OzdGcZrUAEQ")]
        [DisplayName("Message Number")]
        [IsoXmlTag("MsgNb")]
        public required DocumentNumber5Choice_ MessageNumber { get; init; }
    }
}
