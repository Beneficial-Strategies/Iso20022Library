// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LinkedMessage2Choice
{
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_u0o9AQguEeSy_NqeitQG4Q")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public record PreviousReference : LinkedMessage2Choice_
    {
        /// <summary>
        /// Business reference of a message assigned by the party issuing the message. This reference must be unique amongst all messages of the same name sent by the same party.
        /// </summary>
        [IsoId("_Q6vvAtp-Ed-ak6NoX_4Aeg_2103248321")]
        [DisplayName("Reference")]
        [IsoXmlTag("Ref")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Reference { get; init; }

        /// <summary>
        /// Issuer of the reference.
        /// </summary>
        [IsoId("_Q6vvA9p-Ed-ak6NoX_4Aeg_2103249887")]
        [DisplayName("Reference Issuer")]
        [IsoXmlTag("RefIssr")]
        public PartyIdentification2Choice_? ReferenceIssuer { get; init; }

        /// <summary>
        /// Name of a message.
        /// </summary>
        [IsoId("_Q6vvBNp-Ed-ak6NoX_4Aeg_2103249905")]
        [DisplayName("Message Name")]
        [IsoXmlTag("MsgNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MessageName { get; init; }
    }
}
