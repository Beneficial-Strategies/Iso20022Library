// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LinkedMessage5Choice
{
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_rY0jxZTPEemqYPWMBuVawg")]
    [DisplayName("Previous Reference")]
    public record PreviousReference : LinkedMessage5Choice_
    {
        /// <summary>
        /// Message identification of a message. This reference was assigned by the party issuing the message.
        /// </summary>
        [IsoId("_IOb-0ZS9EemqYPWMBuVawg")]
        [DisplayName("Reference")]
        [IsoXmlTag("Ref")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Reference { get; init; }

        /// <summary>
        /// Issuer of the reference.
        /// </summary>
        [IsoId("_IOb-05S9EemqYPWMBuVawg")]
        [DisplayName("Reference Issuer")]
        [IsoXmlTag("RefIssr")]
        public PartyIdentification125Choice_? ReferenceIssuer { get; init; }

        /// <summary>
        /// Name of the message.
        /// </summary>
        [IsoId("_IOb-1ZS9EemqYPWMBuVawg")]
        [DisplayName("Message Name")]
        [IsoXmlTag("MsgNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MessageName { get; init; }
    }
}
